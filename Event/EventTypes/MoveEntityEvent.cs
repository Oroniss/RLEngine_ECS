// Updated for ECS version 1.0.

using System;

namespace ECS.GameEvents
{
	[Serializable]
	public class MoveEntityEvent:GameEvent
	{
		int _entityId;
		int _oldX;
		int _oldY;
		int _newX;
		int _newY;

		MoveEntityEvent(int entityId, int oldX, int oldY, int newX, int newY)
			:base(EventType.MoveEntity)
		{
			_entityId = entityId;
			_oldX = oldX;
			_oldY = oldY;
			_newX = newX;
			_newY = newY;
		}

		public int EntityId
		{
			get { return _entityId; }
		}

		public int OldX
		{
			get { return _oldX; }
		}

		public int OldY
		{
			get { return _oldY; }
		}

		public int NewX
		{
			get { return _newX; }
		}

		public int NewY
		{
			get { return _newY; }
		}

		public static void NewMovementEvent(int entityId, int oldX, int oldY, int newX, int newY)
		{
			var newEvent = new MoveEntityEvent(entityId, oldX, oldY, newX, newY);
			AddEvent(newEvent);
		}
	}
}
