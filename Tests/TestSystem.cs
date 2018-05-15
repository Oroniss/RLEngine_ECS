/* 
* Purpose of this class is to create a "dummy" system to test for events - since they can only be picked
* through listeners. It should never be initialised in an actual game.
* 
* By default it listens to all types of events.
*/

using ECS.GameSystems;
using ECS.GameEvents;
using System.Collections.Generic;

namespace ECS.Testing
{
	public class TestSystem:GameSystem
	{
		readonly List<GameEvent> _events;

		public TestSystem()
			: base("TestSystem", AllEventTypes)
		{
			_events = new List<GameEvent>();
		}

		public override void ProcessEvent(GameEvent gameEvent)
		{
			base.ProcessEvent(gameEvent);

			_events.Add(gameEvent);
		}

		public GameEvent GetNextEvent()
		{
			if (_events.Count == 0)
				return null;

			var toReturn = _events[0];
			_events.RemoveAt(0);
			return toReturn;
		}
	}
}
