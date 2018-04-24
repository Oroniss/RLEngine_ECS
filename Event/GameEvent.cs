using System.Collections.Generic;
using ECS.GameSystems;
using System;

namespace ECS.GameEvents
{
	[Serializable]
	public abstract class GameEvent
	{
		static bool setupRequired = true;
		static SortedDictionary<EventType, List<GameSystem>> listeners;

		static readonly int _maxEvents = 256; // TODO: Keep an eye on this - it may depend on how many events are generated.
		static GameEvent[] _recentEvents = new GameEvent[_maxEvents];
		static int _eventIndex;
		static List<GameEvent> _eventsToProcess = new List<GameEvent>();

		EventType _eventType;

		public GameEvent(EventType eventType)
		{
			_eventType = eventType;
		}

		public EventType EventType
		{
			get { return _eventType; }
		}

		protected static void AddEvent(GameEvent gameEvent)
		{
			_eventsToProcess.Add(gameEvent);
		}

		public static void ProcessEvents()
		{
				while (_eventsToProcess.Count > 0)
				{
					GameEvent processing = _eventsToProcess[0];

					_recentEvents[_eventIndex] = processing;
					_eventIndex = (_eventIndex + 1) % _recentEvents.Length;

					foreach (GameSystem system in listeners[processing.EventType])
						system.ProcessEvent(processing);
					_eventsToProcess.RemoveAt(0);
				}
		}

		public static void RegisterSystem(GameSystem gameSystem, EventType[] watchedEvents)
		{
			if (setupRequired)
				SetupListeners();

			foreach (EventType eventType in watchedEvents)
				listeners[eventType].Add(gameSystem);
		}

		static void SetupListeners()
		{
			listeners = new SortedDictionary<EventType, List<GameSystem>>();
			
			foreach (EventType eventType in Enum.GetValues(typeof(EventType)))
				listeners[eventType] = new List<GameSystem>();

			setupRequired = false;
		}
	}
}
