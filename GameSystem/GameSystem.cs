using System;

namespace ECS.GameSystems
{
	[Serializable]
	public abstract class GameSystem
	{
		// Groups
		// Events

		public GameSystem()
		{
		}

		// Anything that the system should do every turn.
		public virtual void Update(int currentTime)
		{
		}
	}
}
