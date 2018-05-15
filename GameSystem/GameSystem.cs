// Updated for ECS version 1.0.

using RLEngine.GameEvents;
using System;

namespace RLEngine.GameSystems
{
	public abstract class GameSystem
	{
		protected static EventType[] AllEventTypes = (EventType[])Enum.GetValues(typeof(EventType));

		string _systemName;
		EventType[] _watchedEvents;

		protected GameSystem(string systemName, EventType[] watchedEvents)
		{
			_systemName = systemName;

			_watchedEvents = new EventType[watchedEvents.Length];
			for (int i = 0; i < _watchedEvents.Length; i++)
				_watchedEvents[i] = watchedEvents[i];

			GameEvent.RegisterSystem(this, _watchedEvents);
		}

		// Any events the system should watch for.
		public virtual void ProcessEvent(GameEvent gameEvent) { }
	}
}
