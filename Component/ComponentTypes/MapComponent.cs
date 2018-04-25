using System;

namespace ECS.Components
{
	[Serializable]
	public class MapComponent:Component
	{
		int _mapWidth;
		int _mapHeight;
		int[] _tileGrid;

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
			int index = ConvertXYToIndex(x, y);
			return _tileGrid[index];
		}

		int ConvertXYToIndex(int x, int y)
		{
			return y * _mapWidth + x;
		}
	}
}
