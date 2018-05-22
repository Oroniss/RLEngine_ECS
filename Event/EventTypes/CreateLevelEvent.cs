using System;

namespace RLEngine.GameEvents
{
	[Serializable]
	public class CreateLevelEvent:GameEvent
	{
		string _levelName;
		int _levelEntityId;

		CreateLevelEvent(string levelName, int levelEntityId)
			:base(EventType.CreateLevel)
		{
			_levelName = levelName;
			_levelEntityId = levelEntityId;
		}

		public string LevelName
		{
			get { return _levelName; }
		}

		public int LevelEntityId
		{
			get { return _levelEntityId; }
		}

		public static void NewCreateLevelEvent(string levelName, int levelEntityId)
		{
			var newEvent = new CreateLevelEvent(levelName, levelEntityId);
			AddEvent(newEvent);
		}
	}
}
