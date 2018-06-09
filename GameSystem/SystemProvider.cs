// Updated for ECS version 1.0.

using RLEngine.GameEvents;

namespace RLEngine.GameSystems
{
	public static class SystemProvider
	{
		static readonly EventType[] levelSystemEvents =
		{EventType.CreateEntity, EventType.DestroyEntity, EventType.MoveEntity, EventType.CreateLevel};

		static EventType[] movementSystemEvents = 
		{ EventType.CreateEntity, EventType.DestroyEntity, EventType.MoveEntity };

		static EventType[] entitySystemEvents = { };

		static EventType[] drawingSystemEvents = { EventType.CreateEntity, EventType.DestroyEntity, EventType.CreateLevel, EventType.MoveEntity };

		static readonly EntitySystem entitySystem = new EntitySystem(entitySystemEvents);
		static readonly LevelSystem levelSystem = new LevelSystem(levelSystemEvents);
		static readonly MovementSystem movementSystem = new MovementSystem(movementSystemEvents);
		static readonly DrawingSystem drawingSystem = new DrawingSystem(drawingSystemEvents);

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

		public static DrawingSystem DrawingSystem
		{
			get { return drawingSystem; }
		}
	}
}
