using System;

namespace ECS.GameEvents
{
	[Serializable]
	public class CreateEntityEvent:GameEvent
	{
		int _entityId;

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
