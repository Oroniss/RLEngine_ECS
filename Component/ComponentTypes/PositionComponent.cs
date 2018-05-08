using System;
using System.Collections.Generic;

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
		}

		public PositionComponent(int entityId, Dictionary<string, string> otherParameters)
			: base(ComponentType.Position, entityId)
		{
			_xLoc = GetIntParameter("xLoc", otherParameters);
			_yLoc = GetIntParameter("yLoc", otherParameters);
			_levelName = GetStringParameter("levelName", otherParameters);
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

		public void UpdatePosition(int newX, int newY)
		{
			_xLoc = newX;
			_yLoc = newY;
		}
	}
}
