using System;
using System.Collections.Generic;
using ECS.Components;

namespace ECS.Entities
{
	public static class Entity
	{
		static List<int> unusedEntityIds = new List<int>();
		static int maxEntityId = 0;

		static SortedDictionary<int, Component[]> components = new SortedDictionary<int, Component[]> { };
		static SortedDictionary<int, int[]> traits = new SortedDictionary<int, int[]> { };

		static readonly int numberOfComponents = Enum.GetValues(typeof(ComponentType)).Length;
		static readonly Type[] _types = { typeof(PositionComponent), typeof(ForegroundComponent), 
			typeof(BackgroundComponent) };
		static readonly int numberOfTraits = Enum.GetValues(typeof(Trait)).Length;

		public static int CreateEntity()
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

			components[entityID] = new Component[numberOfComponents];
			traits[entityID] = new int[numberOfTraits];

			return entityID;
		}

		public static void DestroyEntity(int entityId)
		{
			if (IsValidEntityId(entityId))
			{
				var componentArray = components[entityId];
				var traitArray = traits[entityId];

				for (int i = 0; i < numberOfComponents; i++)
				{
					if (componentArray[i] != null)
						RemoveComponent(entityId, (ComponentType)i);
				}
				components.Remove(entityId);
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

		public static bool IsValidEntityId(int entityId)
		{
			return components.ContainsKey(entityId) && traits.ContainsKey(entityId);
		}

		public static bool HasComponent(int entityId, ComponentType componentType)
		{
			if (IsValidEntityId(entityId))
			{
				int index = (int)componentType;
				return components[entityId][index] != null;
			}
			else
			{
				ErrorLogger.AddDebugText(string.Format("Invalid Entity ID: {0}", entityId));
				return false;
			}
		}

		public static void AddComponent(int entityId, Component component)
		{
			if (IsValidEntityId(entityId))
			{
				if (components[entityId][(int)component.componentType] != null)
					RemoveComponent(entityId, component.componentType);
				components[entityId][(int)component.componentType] = component;
			}
			else
				ErrorLogger.AddDebugText(string.Format("Tried to add component to invalid Entity ID: {0}", entityId));
		}

		public static void RemoveComponent(int entityId, ComponentType componentType)
		{
			if (IsValidEntityId(entityId))
			{
				components[entityId][(int)componentType] = null;
			}
			else
				ErrorLogger.AddDebugText(string.Format("Unknown Entity ID: {0}", entityId));
		}

		public static bool HasTrait(int entityId, Trait trait)
		{
			if (IsValidEntityId(entityId))
			{
				int index = (int)trait;
				return traits[entityId][index] > 0;
			}
			else
			{
				ErrorLogger.AddDebugText(string.Format("Checked for trait on invalid entity id: {0}", entityId));
				return false;
			}
		}

		public static void AddTrait(int entityId, Trait trait)
		{
			if (IsValidEntityId(entityId))
			{
				int index = (int)trait;
				traits[entityId][index] = traits[entityId][index] + 1;
			}
			else
				ErrorLogger.AddDebugText(string.Format("Tried to add trait {0} to invalid entity id: {1}",
				                                       trait, entityId));
		}

		public static void RemoveTrait(int entityId, Trait trait)
		{
			if (IsValidEntityId(entityId))
			{
				int index = (int)trait;
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
	}
}
