// Revised for ECS version 1.0.

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
			_xLoc = GetIntParameter("XLoc", otherParameters);
			_yLoc = GetIntParameter("YLoc", otherParameters);
			_levelName = GetStringParameter("LevelName", otherParameters);
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
