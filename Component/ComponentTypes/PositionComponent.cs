using System;

namespace ECS.Components
{
	[Serializable]
	public class PositionComponent:Component
	{
		int _xLoc;
		int _yLoc;
		string _levelName;

		public PositionComponent(int entityId, int x, int y, string levelName)
			:base(ComponentType.Position, entityId)
		{
			_xLoc = x;
			_yLoc = y;
			_levelName = levelName;

			// Add to PositionSystem
		}

		public int XLoc
		{
			get { return _xLoc; }
		}

		public int YLoc
		{
			get { return _yLoc; }
		}

		public string LevelName
		{
			get { return _levelName; }
		}
	}
}
