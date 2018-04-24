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
			int originalX = _xLoc;
			int originalY = _yLoc;

			_xLoc = newX;
			_yLoc = newY;

			GameEvents.MoveEntityEvent.NewMovementEvent(EntityId, originalX, originalY, newX, newY);
		}
	}
}
