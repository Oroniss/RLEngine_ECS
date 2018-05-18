using System;
using System.Collections.Generic;

namespace RLEngine.Components
{
	[Serializable]
	public class MapComponent:Component
	{
		readonly int _mapWidth;
		readonly int _mapHeight;
		readonly int[] _tileGrid;
		bool[] _revealed;

		public MapComponent(int entityId, int width, int height, int[] tileGrid)
			:base(ComponentType.Map, entityId)
		{
			_mapWidth = width;
			_mapHeight = height;
			_tileGrid = new int[width * height];
			_revealed = new bool[width * height];

			for (int i = 0; i < width * height; i++)
				_tileGrid[i] = tileGrid[i];
		}

		public MapComponent(int entityId, Dictionary<string, string> otherParameters)
			: base(ComponentType.Map, entityId)
		{
			_mapWidth = GetIntParameter("MapWidth", otherParameters);
			_mapHeight = GetIntParameter("MapHeight", otherParameters);

			_tileGrid = new int[Width * Height];
			_revealed = new bool[Width * Height];
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

		public bool IsRevealed(int x, int y)
		{
			var index = ConvertXYToIndex(x, y);
			return _revealed[index];
		}

		public void RevealTile(int x, int y)
		{
			var index = ConvertXYToIndex(x, y);
			_revealed[index] = true;
		}

		int ConvertXYToIndex(int x, int y)
		{
			return y * _mapWidth + x;
		}
	}
}
