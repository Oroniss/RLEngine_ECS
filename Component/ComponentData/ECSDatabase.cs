using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ECS.Components.ComponentData
{
	public static class ECSDatabase
	{
		static string _componentDataPath;
		static string _traitDataPath;

		static Dictionary<string, Dictionary<string, string>> _componentData = 
			new Dictionary<string, Dictionary<string, string>>();

		static Dictionary<string, List<Trait>> _traits =
			new Dictionary<string, List<Trait>>();

		public static Dictionary<string, string> GetComponentData(string entityName)
		{
			if (!_componentData.ContainsKey(entityName))
				_componentData[entityName] = QueryComponentDatabase(entityName);
			return _componentData[entityName];
		}

		public static Dictionary<string, string> GetComponentData(string entityName, string materialName)
		{
			if (!_componentData.ContainsKey(materialName + entityName))
			{
				var entityDate = QueryComponentDatabase(entityName);
				var materialData = QueryComponentDatabase(materialName);
				_componentData[materialName + entityName ] = CombineParameterDictionaries(entityDate, materialData);
			}
			return _componentData[materialName + entityName];
		}

		static Dictionary<string,string> QueryComponentDatabase(string entityName)
		{
			var fileReader = new StreamReader(_componentDataPath);
			var header = fileReader.ReadLine().Split(',');
			if (header[0] != "EntityName")
			{
				fileReader.Close();
				ErrorLogger.AddDebugText("Invalid entity file format");
				return null;
			}

			var entityDetails = new Dictionary<string, string>();
			string line;
			while ((line = fileReader.ReadLine()) != null)
			{
				var splitLine = line.Split(',');

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

		public static List<Trait> GetTraitData(string entityName)
		{
			if (!_traits.ContainsKey(entityName))
				_traits[entityName] = QueryTraitDatabase(entityName);
			return _traits[entityName];
		}

		public static List<Trait> GetTraitData(string entityName, string materialName)
		{
			if (!_traits.ContainsKey(materialName + entityName))
			{
				var entityTraits = QueryTraitDatabase(entityName);
				var materialTraits = QueryTraitDatabase(materialName);
				_traits[materialName + entityName] = CombineTraitLists(materialTraits, entityTraits);
			}

			return _traits[materialName + entityName];
		}

		static List<Trait> QueryTraitDatabase(string entityName)
		{
			var fileReader = new StreamReader(_traitDataPath);
			var header = fileReader.ReadLine().Split(',');
			if (header[0] != "EntityName")
			{
				fileReader.Close();
				ErrorLogger.AddDebugText("Invalid trait file format");
				return null;
			}

			var traits = new List<Trait>();
			string line;
			while ((line = fileReader.ReadLine()) != null)
			{
				var splitLine = line.Split(',');

				if (splitLine[0] == entityName)
				{
					for (int i = 1; i < splitLine.Length; i++)
					{
						if (splitLine[i] != "")
							traits.Add(ParseTrait(splitLine[i]));
					}
					break;
				}
			}
			fileReader.Close();

			return traits;
		}

		static List<Trait> CombineTraitLists(List<Trait> list1, List<Trait> list2)
		{
			return list1.Concat(list2).ToList();
		}

		static Trait ParseTrait(string trait)
		{
			return (Trait)System.Enum.Parse(typeof(Trait), trait);
		}

		// Primarily here to set the test context for unit testing.
		public static void SetParentFolder(string path)
		{
			_componentDataPath = Path.Combine(path, "ComponentData.csv");
			_traitDataPath = Path.Combine(path, "TraitData.csv");
		}
	}
}
