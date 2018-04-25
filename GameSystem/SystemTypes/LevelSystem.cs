using System;
using System.Collections.Generic;
using ECS.GameEvents;

namespace ECS.GameSystems
{
	public class MapSystem:GameSystem
	{
		static readonly EventType[] watchedEvents = 
		{EventType.CreateEntity, EventType.DestroyEntity, EventType.MoveEntity};

		static SortedDictionary<int, List<int>> entities;
		static int levelWidth;
		static int levelHeight;

		public MapSystem()
			:base("MapSystem", watchedEvents)
		{
		}
	}
}
