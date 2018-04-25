using ECS.GameEvents;
using ECS.Entities;
using ECS.Components;

namespace ECS.GameSystems
{
	public class MovementSystem:GameSystem
	{
		static EventType[] watchedEvents = {EventType.CreateEntity, EventType.DestroyEntity, EventType.MoveEntity};

		public MovementSystem()
			: base("MovementSystem", watchedEvents) { }

		public bool MoveEntityAttempt(int entityId, int levelId, int oldX, int oldY, int newX, int newY)
		{
			if (SystemProvider.LevelSystem.IsValidMapCoord(levelId, newX, newY))
			{
				var positionComponent = (PositionComponent)(Entity.GetComponent(entityId, ComponentType.Position));
				positionComponent.UpdatePosition(newX, newY);
				MoveEntityEvent.NewMovementEvent(entityId, oldX, oldY, newX, newY);
				return true;
			}
			else
				return false; // TODO: If this is the player, print a message to the screen.
		}

		// TODO: Update pathibility
	}
}
