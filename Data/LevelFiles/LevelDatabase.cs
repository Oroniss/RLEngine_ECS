using System.IO;

namespace RLEngine.Levels.LevelData
{
	public static class LevelDatabase
	{
		static string levelFilePath;

		public static LevelDetails GetLevelData(string levelName)
		{
			var fileReader = new StreamReader(Path.Combine(levelFilePath, levelName + ".csv"));

			var returnData = new LevelDetails(levelName);

			if (fileReader.ReadLine().Trim() != levelName)
			{
				ErrorLogger.AddDebugText("Invalid level file: " + levelName);
				ErrorLogger.AddDebugText("Level name does not match file name");
				return returnData;
			}

			returnData.MapWidth = int.Parse(fileReader.ReadLine().Trim());
			returnData.MapHeight = int.Parse(fileReader.ReadLine().Trim());

			if (fileReader.ReadLine().Trim() != "###")
			{
				ErrorLogger.AddDebugText("Invalid level file: " + levelName);
				ErrorLogger.AddDebugText("Incorrect end to heading section");
				return returnData;
			}

			string line;

			while ((line = fileReader.ReadLine().Trim()) != "###")
			{
				var splitLine = line.Split(',');
				returnData.TileDictionary[int.Parse(splitLine[0])] = splitLine[1];
			}

			returnData.TileGrid = new int[returnData.MapHeight * returnData.MapWidth];

			for (int y = 0; y < returnData.MapHeight; y++)
			{
				var splitline = fileReader.ReadLine().Trim().Split(',');
				for (int x = 0; x < returnData.MapWidth; x++)
					returnData.TileGrid[y * returnData.MapWidth + x] = int.Parse(splitline[x]);
			}

			if (fileReader.ReadLine().Trim() != "###")
			{
				ErrorLogger.AddDebugText("Invalid level file: " + levelName);
				ErrorLogger.AddDebugText("Invalid map section");
				return returnData;
			}

			return returnData;
		}

		public static void SetParentFolder(string path)
		{
			levelFilePath = Path.Combine(path, "Data", "LevelFiles");
		}
	}
}
