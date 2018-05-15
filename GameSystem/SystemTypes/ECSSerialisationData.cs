// Updated for ECS version 1.0.

using System;
using System.Collections.Generic;
using RLEngine.Components;

namespace RLEngine.GameSystems
{
	[Serializable]
	public class ECSSerialisationData
	{
		public SortedDictionary<int, PositionComponent> PositionComponents = new SortedDictionary<int, PositionComponent>();
		public SortedDictionary<int, ForegroundComponent> ForegroundComponents = new SortedDictionary<int, ForegroundComponent>();
		public SortedDictionary<int, BackgroundComponent> BackgroundComponents = new SortedDictionary<int, BackgroundComponent>();
		public SortedDictionary<int, MapComponent> MapComponents = new SortedDictionary<int, MapComponent>();

		public SortedDictionary<int, bool[]> Components = new SortedDictionary<int, bool[]>();
		public SortedDictionary<int, int[]> Traits = new SortedDictionary<int, int[]>();
	}
}
