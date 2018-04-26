namespace ECS.GameSystems
{
	public static class SystemProvider
	{
		static EntitySystem entitySystem = new EntitySystem();
		static LevelSystem levelSystem = new LevelSystem();
		static MovementSystem movementSystem = new MovementSystem();

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
