using System;
using System.Collections.Generic;
using ECS.Components;

namespace ECS.Entities
{
	public static class Entity
	{
		static List<int> _unusedEntityIds = new List<int>();
		static int maxEntityId = 0;
		static SortedDictionary<int, Component[]> _entities = new SortedDictionary<int, Component[]> { };

		static int numberOfComponents = Enum.GetValues(typeof(ComponentType)).Length;
		static Type[] _types = new Type[] {typeof(FooComponent), typeof(BarComponent) };

		public static bool HasComponent(int entityId, ComponentType componentType)
		{
			if (!_entities.ContainsKey(entityId))
			{
				Console.WriteLine(string.Format("Unknown Entity ID: {0}", entityId));
				return false;
			}

			int index = (int)componentType;
			return _entities[entityId][index] != null;
		}

		public static int CreateEntity()
		{
			if (_unusedEntityIds.Count == 0)
			{
				int entityID = maxEntityId;
				maxEntityId++;
				_entities[entityID] = new Component[numberOfComponents];
				return entityID;
			}
			else
			{
				int entityID = _unusedEntityIds[0];
				_unusedEntityIds.RemoveAt(0);
				return entityID;
			}
		}

		public static void DestroyEntity(int entityId)
		{
			if (_entities.ContainsKey(entityId))
			{
				var componentArray = _entities[entityId];

				for (int i = 0; i < numberOfComponents; i++)
				{
					if (componentArray[i] != null)
						RemoveComponent(entityId, (ComponentType)i);
				}

				_entities.Remove(entityId);
			}
			_unusedEntityIds.Add(entityId);
		}

		public static void AddComponent(int entityId, Component component)
		{
			if (_entities.ContainsKey(entityId))
			{
				if (_entities[entityId][(int)component.componentType] != null)
					RemoveComponent(entityId, component.componentType);
				_entities[entityId][(int)component.componentType] = component;

				Groups.Group.AddComponentEvent(entityId, component.componentType);
			}
			else
				Console.WriteLine(string.Format("Tried to add component to unknown Entity ID: {0}", entityId));
		}

		public static void RemoveComponent(int entityId, ComponentType componentType)
		{
			if (_entities.ContainsKey(entityId))
			{
				_entities[entityId][(int)componentType] = null;

				Groups.Group.RemoveComponentEvent(entityId, componentType);
			}
			else
				Console.WriteLine(string.Format("Unknown Entity ID: {0}", entityId));
		}
	}
}
