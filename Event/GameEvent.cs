using System.Collections.Generic;

namespace ECS.GameEvents
{
	public class GameEvent
	{
		static GameEvent[] _recentEvents;
		static int _eventIndex;
		static List<GameEvent> _eventsToProcess;

		public GameEvent()
		{
		}



		public static void AddEvent(GameEvent gameEvent)
		{
			_recentEvents[_eventIndex] = gameEvent;
			_eventIndex = (_eventIndex + 1) % _recentEvents.Length;

			_eventsToProcess.Add(gameEvent);

			if (_eventsToProcess.Count == 1)
			{
				while (_eventsToProcess.Count > 0)
				{
					// TODO: Check for listeners here.
					_eventsToProcess.RemoveAt(0);
				}
			}

		}
	}
}
