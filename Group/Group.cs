using System;
using ECS.Components;
using System.Collections.Generic;

namespace ECS.Groups
{
	[Serializable]
	public class Group
	{
		static SortedDictionary<string, Group> groups;
		static int maxGroupID = 0;
		static SortedDictionary<ComponentType, List<string>> components;

		string _groupName;
		List<ComponentType> _requiredComponents;
		SortedDictionary<int, bool[]> _entities;
		List<int> _groupMembers;

		public Group(string groupName, ComponentType[] requiredComponents)
		{
			if (components == null)
				InitialiseGroups();

			_groupName = groupName;
			groups[_groupName] = this;

			_requiredComponents = new List<ComponentType>();
			for (int i = 0; i < requiredComponents.Length; i++)
			{
				_requiredComponents.Add(requiredComponents[i]);
				components[requiredComponents[i]].Add(_groupName);
			}

			_entities = new SortedDictionary<int, bool[]>();
			_groupMembers = new List<int>();
		}

		void AddComponent(int entityId, ComponentType componentType)
		{
			if (!_entities.ContainsKey(entityId))
				_entities[entityId] = new bool[_requiredComponents.Count];
			int index = _requiredComponents.IndexOf(componentType);
			_entities[entityId][index] = true;
			if (CheckIfMember(entityId))
				_groupMembers.Add(entityId);
		}

		bool CheckIfMember(int entityID)
		{
			for (int i = 0; i < _requiredComponents.Count; i++)
			{
				if (!_entities[entityID][i])
					return false;
			}
			return true;
		}

		void RemoveComponent(int entityId, ComponentType componentType)
		{
			while (_groupMembers.Contains(entityId))
				_groupMembers.Remove(entityId);

			int index = _requiredComponents.IndexOf(componentType);
			_entities[entityId][index] = false;
			if (CheckIfDelete(entityId))
				_entities.Remove(entityId);
		}

		bool CheckIfDelete(int entityId)
		{
			for (int i = 0; i < _requiredComponents.Count; i++)
			{
				if (_entities[entityId][i])
					return false;
			}
			return true;
		}

		public static void AddComponentEvent(int entityId, ComponentType componentType)
		{
			for (int i = 0; i < components[componentType].Count; i++)
				groups[components[componentType][i]].AddComponent(entityId, componentType);
		}

		public static void RemoveComponentEvent(int entityId, ComponentType componentType)
		{
			for (int i = 0; i<components[componentType].Count; i++)
				groups[components[componentType][i]].RemoveComponent(entityId, componentType);
		}

		static void InitialiseGroups()
		{
			components = new SortedDictionary<ComponentType, List<string>>();
			groups = new SortedDictionary<string, Group>();

			foreach (ComponentType componentType in Enum.GetValues(typeof(ComponentType)))
				components[componentType] = new List<string>();
		}
	}
}
