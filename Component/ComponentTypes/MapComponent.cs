using System;
using System.Collections.Generic;

namespace ECS.Components
{
	[Serializable]
	public class MapComponent:Component
	{
		readonly int _mapWidth;
		readonly int _mapHeight;
		readonly int[] _tileGrid;

		public MapComponent(int entityId, int width, int height, int[,] tileGrid)
			:base(ComponentType.Map, entityId)
		{
			_mapWidth = width;
			_mapHeight = height;
			_tileGrid = new int[width * height];
			for (int y = 0; y < _mapHeight; y++)
			{
				for (int x = 0; x < _mapWidth; x++)
					_tileGrid[ConvertXYToIndex(x, y)] = tileGrid[y, x];
			}
		}

		public MapComponent(int entityId, Dictionary<string, string> otherParameters)
			: base(ComponentType.Map, entityId)
		{
			_mapWidth = GetIntParameter("MapWidth", otherParameters);
			_mapHeight = GetIntParameter("MapHeight", otherParameters);

			_tileGrid = new int[Width * Height];
			var tileString = GetStringParameter("TileGrid", otherParameters).Split(',');
			for (int i = 0; i < Width * Height; i++)
				_tileGrid[i] = int.Parse(tileString[i]);
		}

		public int Width
		{
			get { return _mapWidth; }
		}

		public int Height
		{
			get { return _mapHeight; }
		}

		public int GetMapTile(int x, int y)
		{
			var index = ConvertXYToIndex(x, y);
			return _tileGrid[index];
		}

		int ConvertXYToIndex(int x, int y)
		{
			return y * _mapWidth + x;
		}
	}
}
