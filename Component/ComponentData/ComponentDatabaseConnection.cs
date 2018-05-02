using System.Collections.Generic;
using System.IO;

namespace ECS.Components.ComponentData
{
	public class ComponentDatabaseConnection
	{
		string _componentDataParentFolder;
		Dictionary<string, Dictionary<string, string>> _componentData;

		public ComponentDatabaseConnection()
		{
			_componentData = new Dictionary<string, Dictionary<string, string>>();
		}

		public Dictionary<string, string> GetComponentData(string entityName)
		{
			if (!_componentData.ContainsKey(entityName))
				ReadData();
			return _componentData[entityName];
		}

		public Dictionary<string, string> GetComponentData(string entityName, string materialName)
		{
			return CombineDictionaries(GetComponentData(entityName), GetComponentData(materialName));
		}

		void ReadData()
		{
			StreamReader fileReader = new StreamReader(_componentDataParentFolder);
			string line;
			while ((line = fileReader.ReadLine()) != null)
			{
				Dictionary<string, string> entityDetails = new Dictionary<string, string>();
				string[] splitLine = line.Split(',');
				for (int i = 0; i < splitLine.Length; i += 2)
				{
					if (splitLine[i] != "")
						entityDetails[splitLine[i]] = splitLine[i + 1];
				}
				if (entityDetails.ContainsKey("EntityName"))
					_componentData[entityDetails["EntityName"]] = entityDetails;
				else
					ErrorLogger.AddDebugText("Entity without a valid entity name. 0 = " + 
					                         splitLine[0] + ", 1 = " + splitLine[1]);
			}
		}

		Dictionary<string, string> CombineDictionaries(Dictionary<string, string> dictionary1, 
		                                               Dictionary<string, string> dictionary2)
		{
			Dictionary<string, string> returnDict = new Dictionary<string, string> (dictionary1);
			foreach (string key in dictionary2.Keys)
			{
				if (dictionary1.ContainsKey(key))
					ErrorLogger.AddDebugText(string.Format("Two different versions of parameter {0}", key));
				else
					returnDict[key] = dictionary2[key];
			}
			return returnDict;
		}

		// Primarily here to set the test context for unit testing.
		public void SetParentFolder(string path)
		{
			_componentDataParentFolder = path;
		}
	}
}
