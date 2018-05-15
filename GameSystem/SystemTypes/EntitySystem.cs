// Updated for ECS version 1.0.

using System;
using System.Collections.Generic;
using ECS.Components;
using ECS.GameEvents;
using System.Linq;

namespace ECS.GameSystems
{
	public partial class EntitySystem:GameSystem
	{
		List<int> unusedEntityIds = new List<int>();
		int maxEntityId; // Will default to 0.

		SortedDictionary<ComponentType, SortedDictionary<int, Component>> components =
			new SortedDictionary<ComponentType, SortedDictionary<int, Component>>();
		SortedDictionary<int, bool[]> hasComponent = new SortedDictionary<int, bool[]> { };
		SortedDictionary<int, int[]> traits = new SortedDictionary<int, int[]> { };

		readonly int numberOfComponents = Enum.GetValues(typeof(ComponentType)).Length;
		readonly Type[] _types = { typeof(PositionComponent), typeof(ForegroundComponent),
					typeof(BackgroundComponent), typeof(MapComponent) }; // TODO: Keep updated.
		readonly int numberOfTraits = Enum.GetValues(typeof(Trait)).Length;


		public EntitySystem(EventType[] watchedEvents)
			: base("EntitySystem", watchedEvents) 
		{
			foreach (ComponentType componentType in Enum.GetValues(typeof(ComponentType)))
				components[componentType] = new SortedDictionary<int, Component>();
		}

		Dictionary<string, string> CombineParameterDictionaries(Dictionary<string, string> dict1, 
		                                                        Dictionary<string, string> dict2)
		{
			return dict1.Union(dict2).ToDictionary(k => k.Key, v => v.Value);
		}

		int GetNewEntityId()
		{
			int entityID;

			if (unusedEntityIds.Count == 0)
			{
				entityID = maxEntityId;
				maxEntityId++;
			}
			else
			{
				entityID = unusedEntityIds[0];
				unusedEntityIds.RemoveAt(0);
			}

			hasComponent[entityID] = new bool[numberOfComponents];
			traits[entityID] = new int[numberOfTraits];

			return entityID;
		}

		public void DestroyEntity(int entityId)
		{
			if (IsValidEntityId(entityId))
			{
				var componentArray = hasComponent[entityId];
				var traitArray = traits[entityId];

				for (int i = 0; i < numberOfComponents; i++)
				{
					if (componentArray[i])
						RemoveComponent(entityId, (ComponentType)i);
				}
				hasComponent.Remove(entityId);
				for (int i = 0; i < numberOfTraits; i++)
				{
					while (traitArray[i] > 0)
						RemoveTrait(entityId, (Trait)i);
				}
				traits.Remove(entityId);

				unusedEntityIds.Add(entityId);
			}
			else
				ErrorLogger.AddDebugText(string.Format("Tried to destroy invalid entity: {0}", entityId));
		}

		public bool IsValidEntityId(int entityId)
		{
			return hasComponent.ContainsKey(entityId) && traits.ContainsKey(entityId);
		}

		public bool HasComponent(int entityId, ComponentType componentType)
		{
			if (IsValidEntityId(entityId))
			{
				var index = (int)componentType;
				return hasComponent[entityId][index];
			}
			ErrorLogger.AddDebugText(string.Format("Invalid Entity ID: {0}", entityId));
			return false;
		}

		public Component GetComponent(int entityId, ComponentType componentType)
		{
			if (IsValidEntityId(entityId))
			{
				if (HasComponent(entityId, componentType))
					return components[componentType][entityId];
				ErrorLogger.AddDebugText(string.Format("Tried to get non-existant component type: {0} for entity: {1}",
													   componentType, entityId));
				return null;
			}
			ErrorLogger.AddDebugText(string.Format("Invalid Entity ID: {0}", entityId));
			return null;
		}

		public void AddComponent(int entityId, Component component)
		{
			if (IsValidEntityId(entityId))
			{
				if (hasComponent[entityId][(int)component.componentType])
					RemoveComponent(entityId, component.componentType);
				hasComponent[entityId][(int)component.componentType] = true;
				components[component.componentType][entityId] = component;
			}
			else
				ErrorLogger.AddDebugText(string.Format("Tried to add component to invalid Entity ID: {0}", entityId));
		}

		public void RemoveComponent(int entityId, ComponentType componentType)
		{
			if (IsValidEntityId(entityId))
			{
				if (HasComponent(entityId, componentType))
				{
					hasComponent[entityId][(int)componentType] = false;
					components[componentType].Remove(entityId);
				}
				else
					ErrorLogger.AddDebugText(string.Format("Tried to remove a {0} that wasn't present on entity {1}",
														   componentType, entityId));
			}
			else
				ErrorLogger.AddDebugText(string.Format("Unknown Entity ID: {0}", entityId));
		}

		public bool HasTrait(int entityId, Trait trait)
		{
			if (IsValidEntityId(entityId))
			{
				var index = (int)trait;
				return traits[entityId][index] > 0;
			}
			ErrorLogger.AddDebugText(string.Format("Checked for trait on invalid entity id: {0}", entityId));
			return false;
		}

		public void AddTrait(int entityId, Trait trait)
		{
			if (IsValidEntityId(entityId))
			{
				var index = (int)trait;
				traits[entityId][index] = traits[entityId][index] + 1;
			}
			else
				ErrorLogger.AddDebugText(string.Format("Tried to add trait {0} to invalid entity id: {1}",
													   trait, entityId));
		}

		public void RemoveTrait(int entityId, Trait trait)
		{
			if (IsValidEntityId(entityId))
			{
				var index = (int)trait;
				if (traits[entityId][index] > 0)
					traits[entityId][index] = traits[entityId][index] - 1;
				else
					ErrorLogger.AddDebugText(string.Format("Tried to remove non-existante trait {0} from entity id {1}",
														   trait, entityId));
			}
			else
				ErrorLogger.AddDebugText(string.Format("Tried to remove trait {0} from invalid entity id: {1}",
													   trait, entityId));
		}

		public ECSSerialisationData GetSerialisationData()
		{
			var data = new ECSSerialisationData();

			foreach (KeyValuePair<int, Component> item in components[ComponentType.Position])
				data.PositionComponents[item.Key] = (PositionComponent)item.Value;
			foreach (KeyValuePair<int, Component> item in components[ComponentType.Foreground])
				data.ForegroundComponents[item.Key] = (ForegroundComponent)item.Value;
			foreach (KeyValuePair<int, Component> item in components[ComponentType.Background])
				data.BackgroundComponents[item.Key] = (BackgroundComponent)item.Value;
			foreach (KeyValuePair<int, Component> item in components[ComponentType.Map])
				data.MapComponents[item.Key] = (MapComponent)item.Value;

			data.Components = hasComponent;
			data.Traits = traits;

			return data;
		}

		public void LoadSerialisationData(ECSSerialisationData data)
		{
			foreach (KeyValuePair<int, PositionComponent> item in data.PositionComponents)
				components[ComponentType.Position][item.Key] = item.Value;
			foreach (KeyValuePair<int, ForegroundComponent> item in data.ForegroundComponents)
				components[ComponentType.Foreground][item.Key] = item.Value;
			foreach (KeyValuePair<int, BackgroundComponent> item in data.BackgroundComponents)
				components[ComponentType.Background][item.Key] = item.Value;
			foreach (KeyValuePair<int, MapComponent> item in data.MapComponents)
				components[ComponentType.Map][item.Key] = item.Value;

			hasComponent = data.Components;
			traits = data.Traits;
		}
	}
}
