using System.Collections.Generic;
using RLEngine.GameEvents;
using RLEngine.Components;

namespace RLEngine.GameSystems
{
	public class DrawingSystem:GameSystem
	{
		Dictionary<int, LevelDrawingData> _drawingData;

		public DrawingSystem(EventType[] watchedEvents)
			:base("DrawingSystem",watchedEvents)
		{
			_drawingData = new Dictionary<int, LevelDrawingData>();
		}

		public string GetBackgroundColor(int levelId, int x, int y)
		{
			return _drawingData[levelId].GetBackgroundColor(x, y);
		}

		public string GetFogColor(int levelId, int x, int y)
		{
			return _drawingData[levelId].GetFogColor(x, y);
		}

		public ForegroundComponent GetForegroundComponent(int levelId, int x, int y)
		{
			var fgComponents = SystemProvider.LevelSystem.GetComponents(levelId, x, y, ComponentType.Foreground);
			if (fgComponents.Count == 0)
				return null;
			if (fgComponents.Count == 1)
				return (ForegroundComponent)fgComponents[0];

			ForegroundComponent current = (ForegroundComponent)fgComponents[0];

			for (int i = 1; i < fgComponents.Count; i++)
			{
				ForegroundComponent possible = (ForegroundComponent)fgComponents[i];
				if ((int)possible.DisplayLayer > (int)current.DisplayLayer)
					current = possible;
			}
			return current;
		}

		public override void ProcessEvent(GameEvent gameEvent)
		{
			base.ProcessEvent(gameEvent);

			switch (gameEvent.EventType)
			{
				case EventType.CreateEntity:
					{
						var createEvent = (CreateEntityEvent)(gameEvent);
						if (RecalculateRequired(createEvent.EntityId))
							RecalculateBackgroundAtEntityLocation(createEvent.EntityId);
						break;
					}
				case EventType.DestroyEntity:
					{
						// TODO: Finish when destroy event defined
						// var destroyEvent = (DestroyEventEvent)(gameEvent);
						break;
					}
				case EventType.MoveEntity:
					{
						var movementEvent = (MoveEntityEvent)(gameEvent);
						if (RecalculateRequired(movementEvent.EntityId))
						{
							PositionComponent pos = (PositionComponent)SystemProvider.EntitySystem.GetComponent(
								movementEvent.EntityId, ComponentType.Position);

							RecalculateBackgroundAtLocation(pos.LevelId, movementEvent.OldX, movementEvent.OldY);
							RecalculateBackgroundAtLocation(pos.LevelId, movementEvent.NewX, movementEvent.NewY);
						}
						break;
					}
				case EventType.CreateLevel:
					{
						// TODO: Fix this up when Create Level event finished up.
						break;
					}
				// TODO: Some others - level transition, some kind of "AddBackgroundComponentEvent"
			}
		}

		bool RecalculateRequired(int entityId)
		{
			return SystemProvider.EntitySystem.HasComponent(entityId, ComponentType.Background)
				                 && SystemProvider.EntitySystem.HasComponent(entityId, ComponentType.Position);
		}

		void RecalculateBackgroundAtEntityLocation(int entityId)
		{
			var positionComponent = (PositionComponent)SystemProvider.EntitySystem.GetComponent(entityId, ComponentType.Position);
			RecalculateBackgroundAtLocation(positionComponent.LevelId, positionComponent.XLoc, positionComponent.YLoc);
		}

		void RecalculateBackgroundAtLocation(int levelId, int x, int y)
		{
			var bgComponents = SystemProvider.LevelSystem.GetComponents(levelId, x, y, ComponentType.Background);
			var tile = _drawingData[levelId].MapComponent.GetMapTile(x, y);
			var currentBackground = (BackgroundComponent)SystemProvider.EntitySystem.GetComponent(tile, ComponentType.Background);

			for (int i = 0; i < bgComponents.Count; i++)
			{
				var tmpBGComponent = (BackgroundComponent)bgComponents[i];
				if (tmpBGComponent.BackgroundDisplayLayer > currentBackground.BackgroundDisplayLayer)
					currentBackground = tmpBGComponent;
			}

			_drawingData[levelId].SetBackgroundColor(x, y, currentBackground.BackgroundColor);
			_drawingData[levelId].SetFogColor(x, y, currentBackground.FogColor);
		}
	}

	public class LevelDrawingData
	{
		MapComponent _mapComponent;
		Dictionary<int, string> _tileBackgroundColors = new Dictionary<int, string>();
		Dictionary<int, string> _tileFogColors = new Dictionary<int, string>();

		public MapComponent MapComponent
		{
			get { return _mapComponent; }
		}

		int ConvertXYToIndex(int x, int y)
		{
			return y * _mapComponent.Width + x;
		}

		public string GetBackgroundColor(int x, int y)
		{
			var index = ConvertXYToIndex(x, y);
			return _tileBackgroundColors[index];
		}

		public void SetBackgroundColor(int x, int y, string backgroundColor)
		{
			var index = ConvertXYToIndex(x, y);
			_tileBackgroundColors[index] = backgroundColor;
		}

		public string GetFogColor(int x, int y)
		{
			var index = ConvertXYToIndex(x, y);
			return _tileFogColors[index];
		}

		public void SetFogColor(int x, int y, string fogColor)
		{
			var index = ConvertXYToIndex(x, y);
			_tileFogColors[index] = fogColor;
		}
	}
}
