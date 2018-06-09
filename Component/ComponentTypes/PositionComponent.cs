// Revised for ECS version 1.0.

using System;
using System.Collections.Generic;

namespace RLEngine.Components
{
	[Serializable]
	public class PositionComponent:Component
	{
		int _xLoc;
		int _yLoc;
		int _levelId;

		public PositionComponent(int entityId, int x, int y, int levelId)
			:base(ComponentType.Position, entityId)
		{
			_xLoc = x;
			_yLoc = y;
			_levelId = levelId;
		}

		public PositionComponent(int entityId, Dictionary<string, string> otherParameters)
			: base(ComponentType.Position, entityId)
		{
			_xLoc = GetIntParameter("XLoc", otherParameters);
			_yLoc = GetIntParameter("YLoc", otherParameters);
			_levelId = GetIntParameter("LevelId", otherParameters);
		}

		public int XLoc
		{
			get { return _xLoc; }
		}

		public int YLoc
		{
			get { return _yLoc; }
		}

		public int LevelId
		{
			get { return _levelId; }
		}

		public void UpdatePosition(int newX, int newY)
		{
			_xLoc = newX;
			_yLoc = newY;
		}
	}
}
