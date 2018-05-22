// TODO: Eventually this should be used to store the actual level details - just have a function that parses a serialiser and store that.

using System;
using System.Collections.Generic;

namespace RLEngine.Levels
{
	[Serializable]
	public class LevelDetails
	{
		string _levelName;
		public int MapWidth;
		public int MapHeight;

		public SortedDictionary<int, string> TileDictionary = new SortedDictionary<int, string>();

		public int[] TileGrid;

		public List<Dictionary<string, string>> Entities;

		public LevelDetails(string levelName)
		{
			_levelName = levelName;	
		}

		public string LevelName
		{
			get { return _levelName; }
		}
	}
}
