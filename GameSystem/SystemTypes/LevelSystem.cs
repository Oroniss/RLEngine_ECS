using ECS.GameEvents;
using ECS.Components;

namespace ECS.GameSystems
{
	public class LevelSystem:GameSystem
	{
		public LevelSystem(EventType[] watchedEvents)
			: base("LevelSystem", watchedEvents) { }

		public bool IsValidMapCoord(int levelId, int x, int y)
		{
			var mapComponent = (MapComponent)(SystemProvider.EntitySystem.GetComponent(levelId, ComponentType.Map));

			if (mapComponent == null)
			{
				ErrorLogger.AddDebugText("Tried to check coordinates on an entity without a Map Component");
				return false;
			}

			return 0 <= x && x < mapComponent.Width && 0 <= y && y < mapComponent.Height;
		}
	}
}
