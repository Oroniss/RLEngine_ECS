// Revised for ECS version 1.0.

using System;

namespace RLEngine.GameEvents
{
	[Serializable]
	public class CreateEntityEvent:GameEvent
	{
		int _entityId;

		// TODO: Think about how to store/deal with the other entity details.

		CreateEntityEvent(int entityId)
			:base(EventType.CreateEntity)
		{
			_entityId = entityId;
		}

		public int EntityId
		{
			get { return _entityId; }
		}

		public static void NewCreateEntityEvent(int entityId)
		{
			var newEvent = new CreateEntityEvent(entityId);
			AddEvent(newEvent);
		}
	}
}
