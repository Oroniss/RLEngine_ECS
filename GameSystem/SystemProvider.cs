namespace ECS.GameSystems
{
	public static class SystemProvider
	{
		static LevelSystem levelSystem = new LevelSystem();
		static MovementSystem movementSystem = new MovementSystem();

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
