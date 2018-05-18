using System.IO;
using System.Collections.Generic;

namespace RLEngine.Levels.LevelData
{
	public static class LevelDatabase
	{
		static string levelFilePath;

		public static List<string> GetLevelData(string levelName)
		{
			var fileReader = new StreamReader(Path.Combine(levelFilePath, levelName + ".csv"));

			var returnData = new List<string>();

			string line;

			while ((line = fileReader.ReadLine()) != null)
				returnData.Add(line);

			return returnData;
		}

		public static void SetParentFolder(string path)
		{
			levelFilePath = Path.Combine(path, "Data", "LevelFiles");
		}
	}
}
