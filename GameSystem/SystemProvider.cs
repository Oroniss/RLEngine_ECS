using ECS.GameEvents;

namespace ECS.GameSystems
{
	public static class SystemProvider
	{
		static readonly EventType[] levelSystemEvents =
		{EventType.CreateEntity, EventType.DestroyEntity, EventType.MoveEntity};

		static EventType[] movementSystemEvents = 
		{ EventType.CreateEntity, EventType.DestroyEntity, EventType.MoveEntity };

		static EventType[] entitySystemEvents = { };

		static EntitySystem entitySystem = new EntitySystem(entitySystemEvents);
		static LevelSystem levelSystem = new LevelSystem(levelSystemEvents);
		static MovementSystem movementSystem = new MovementSystem(movementSystemEvents);

		public static EntitySystem EntitySystem
		{
			get { return entitySystem; }
		}

		public static LevelSystem LevelSystem
		{
			get { return levelSystem; }
		}

		public static MovementSystem MovementSystem
		{
			get { return movementSystem; }
		}
	}
}
