using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ECS.Components.ComponentData
{
	public static class ComponentDatabase
	{
		static string _componentDataPath;
		static Dictionary<string, Dictionary<string, string>> _componentData = 
			new Dictionary<string, Dictionary<string, string>>();

		public static Dictionary<string, string> GetComponentData(string entityName)
		{
			if (!_componentData.ContainsKey(entityName))
				_componentData[entityName] = GetData(entityName);
			return _componentData[entityName];
		}

		public static Dictionary<string, string> GetComponentData(string entityName, string materialName)
		{
			if (!_componentData.ContainsKey(entityName + materialName))
			{
				var entityDate = GetData(entityName);
				var materialData = GetData(materialName);
				_componentData[entityName + materialName] = CombineParameterDictionaries(entityDate, materialData);
			}
			return _componentData[entityName + materialName];
		}

		static Dictionary<string,string> GetData(string entityName)
		{
			StreamReader fileReader = new StreamReader(_componentDataPath);
			string[] header = fileReader.ReadLine().Split(',');
			if (header[0] != "EntityName")
			{
				fileReader.Close();
				ErrorLogger.AddDebugText("Invalid entity file format");
				return null;
			}

			Dictionary<string, string> entityDetails = new Dictionary<string, string>();
			string line;
			while ((line = fileReader.ReadLine()) != null)
			{
				string[] splitLine = line.Split(',');

				if (splitLine[0] == entityName)
				{
					for (int i = 0; i < splitLine.Length; i++)
					{
						if (splitLine[i] != "")
							entityDetails[header[i]] = splitLine[i];
					}
					break;
				}
			}
			fileReader.Close();

			if (entityDetails.Count == 0)
				ErrorLogger.AddDebugText(string.Format("Couldn't find entity {0} in data file", entityName));
			return entityDetails;
		}

		static Dictionary<string, string> CombineParameterDictionaries(Dictionary<string, string> dict1,
																Dictionary<string, string> dict2)
		{
			return dict1.Union(dict2).ToDictionary(k => k.Key, v => v.Value);
		}

		// Primarily here to set the test context for unit testing.
		public static void SetParentFolder(string path)
		{
			_componentDataPath = path;
		}
	}
}
