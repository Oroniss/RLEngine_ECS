using ECS.GameEvents;

namespace ECS.GameSystems
{
	public abstract class GameSystem
	{
		string _systemName;
		EventType[] _watchedEvents;

		public GameSystem(string systemName, EventType[] watchedEvents)
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
