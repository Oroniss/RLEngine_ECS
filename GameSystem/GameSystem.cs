using ECS.GameEvents;
using System.Collections.Generic;

namespace ECS.GameSystems
{
	public abstract class GameSystem
	{
		static List<GameSystem> systemsToUpdate = new List<GameSystem>();
		static SortedDictionary<string, GameSystem> systems = new SortedDictionary<string, GameSystem>();

		string _systemName;
		EventType[] _watchedEvents;

		public GameSystem(string systemName, EventType[] watchedEvents)
		{
			systemsToUpdate.Add(this);
			systems[systemName] = this;

			_systemName = systemName;

			_watchedEvents = new EventType[watchedEvents.Length];
			for (int i = 0; i < _watchedEvents.Length; i++)
				_watchedEvents[i] = watchedEvents[i];

			GameEvent.RegisterSystem(this, _watchedEvents);
		}

		// Anything that the system should do every turn.
		protected virtual void Update(int currentTime)
		{
		}

		// Any events the system should watch for.
		public virtual void ProcessEvent(GameEvent gameEvent)
		{
		}

		public static void UpdateSystems(int currentTime)
		{
			foreach (GameSystem system in systemsToUpdate)
				system.Update(currentTime);
		}

		public static GameSystem GetSystem(string name)
		{
			if (systems.ContainsKey(name))
				return systems[name];
			ErrorLogger.AddDebugText("Searched for unknown GameSystem: " + name);
			return null;
		}
	}
}
