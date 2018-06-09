using RLEngine.GameEvents;
using RLEngine.Components;
using System.Collections.Generic;

namespace RLEngine.GameSystems
{
	public class LevelSystem:GameSystem
	{
		SortedDictionary<int, MapComponent> _levels;
		SortedDictionary<int, SortedDictionary<int, List<int>>> _entities;

		public LevelSystem(EventType[] watchedEvents)
			: base("LevelSystem", watchedEvents) 
		{
			_levels = new SortedDictionary<int, MapComponent>();
			_entities = new SortedDictionary<int, SortedDictionary<int, List<int>>>();
		}

		public bool IsValidMapCoord(int levelId, int x, int y)
		{
			return 0 <= x && x < _levels[levelId].Width && 0 <= y && y < _levels[levelId].Height;
		}

		public bool HasEntity(int levelId, int x, int y)
		{
			var index = convertXYtoInt(levelId, x, y);
			return HasEntity(levelId, index);
		}

		bool HasEntity(int levelId, int index)
		{
			return _entities[levelId].ContainsKey(index);
		}

		public List<int> GetEntities(int levelId, int x, int y)
		{
			var returnList = new List<int>();

			var index = convertXYtoInt(levelId, x, y);
			if (HasEntity(levelId, index))
			{
				foreach (int entityId in _entities[levelId][index])
					returnList.Add(entityId);
			}

			return returnList;
		}

		public List<Component> GetComponents(int levelId, int x, int y, ComponentType componentType)
		{

			var index = convertXYtoInt(levelId, x, y);
			return GetComponents(levelId, index, componentType);
		}

		List<Component> GetComponents(int levelId, int index, ComponentType componentType)
		{
			var returnList = new List<Component>();

			if (_entities[levelId].ContainsKey(index))
			{
				foreach (int entityId in _entities[levelId][index])
				{
					if (SystemProvider.EntitySystem.HasComponent(entityId, componentType))
						returnList.Add(SystemProvider.EntitySystem.GetComponent(entityId, componentType));
				}
			}

			return returnList;
		}

		public bool HasTrait(int levelId, int x, int y, Trait trait)
		{
			var index = convertXYtoInt(levelId, x, y);
			return HasTrait(levelId, index, trait);
		}

		bool HasTrait(int levelId, int index, Trait trait)
		{
			if (!HasEntity(levelId, index))
				return false;
			foreach (int entityId in _entities[levelId][index])
			{
				if (SystemProvider.EntitySystem.HasTrait(entityId, trait))
					return true;
			}
			return false;
		}

		public void AddEntity(int levelId, int entityId, int x, int y)
		{
			var index = convertXYtoInt(levelId, x, y);
			AddEntity(levelId, entityId, index);
		}

		void AddEntity(int levelId, int entityId, int index)
		{
			// TODO: Add some error checks here?
			if (!_entities[levelId].ContainsKey(index))
				_entities[levelId][index] = new List<int>();
			_entities[levelId][index].Add(entityId);
		}

		public void RemoveEntity(int levelId, int entityId, int x, int y)
		{
			var index = convertXYtoInt(levelId, x, y);
			RemoveEntity(levelId, entityId, index);
		}

		void RemoveEntity(int levelId, int entityId, int index)
		{
			if (!_entities[levelId].ContainsKey(index))
			{
				// TODO: Add error message here
				return;
			}
			if (!_entities[levelId][index].Contains(entityId))
			{
				// TODO: Add error message here
				return;
			}
			_entities[levelId][index].Remove(entityId);
			if (_entities[levelId][index].Count == 0)
				_entities[levelId].Remove(index);
		}

		int convertXYtoInt(int levelId, int x, int y)
		{
			return _levels[levelId].Width * y + x;
		}

		public override void ProcessEvent(GameEvent gameEvent)
		{
			base.ProcessEvent(gameEvent);

			if (gameEvent.EventType == EventType.CreateLevel)
			{
				// TODO: Insert stuff here.
			}
		}
	}
}
