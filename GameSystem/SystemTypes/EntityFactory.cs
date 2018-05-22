using System.Collections.Generic;
using RLEngine.Components;
using RLEngine.Components.ComponentData;

namespace RLEngine.GameSystems
{

	public partial class EntitySystem
	{
		public int CreateEntity(string entityName, Dictionary<string, string> otherParameters)
		{
			var newEntityId = GetNewEntityId();
			Dictionary<string, string> allParameters;
			List<Trait> allTraits;
			if (otherParameters.ContainsKey("Material"))
			{
				allParameters = CombineParameterDictionaries(otherParameters,
					   ECSDatabase.GetComponentData(entityName, otherParameters["Material"]));
				allTraits = ECSDatabase.GetTraitData(entityName, otherParameters["Material"]);
			}
			else
			{
				allParameters = CombineParameterDictionaries(otherParameters,
						   ECSDatabase.GetComponentData(entityName));
				allTraits = ECSDatabase.GetTraitData(entityName);
			}

			GenerateComponents(newEntityId, allParameters, allTraits);

			GameEvents.CreateEntityEvent.NewCreateEntityEvent(newEntityId);

			return newEntityId;	
		}

		void GenerateComponents(int entityId, Dictionary<string, string> allParameters, List<Trait> allTraits)
		{
			if (allParameters.ContainsKey("BackgroundComponent"))
			{
				var component = new BackgroundComponent(entityId, allParameters);
				AddComponent(entityId, component);
			}

			if (allParameters.ContainsKey("ForegroundComponent"))
			{
				var component = new ForegroundComponent(entityId, allParameters);
				AddComponent(entityId, component);
			}

			if (allParameters.ContainsKey("MapComponent"))
			{
				var component = new MapComponent(entityId, allParameters);
				AddComponent(entityId, component);
			}

			if (allParameters.ContainsKey("PositionComponent"))
			{
				var component = new PositionComponent(entityId, allParameters);
				AddComponent(entityId, component);
			}

			// TODO: Setup all the components here.

			foreach (Trait trait in allTraits)
				AddTrait(entityId, trait);
		}

		public int GenerateLevel(string levelName)
		{
			var levelEntityId = GetNewEntityId();

			var levelDetails = Levels.LevelData.LevelDatabase.GetLevelData(levelName);

			var tileDictionary = new Dictionary<int, int>();

			foreach (KeyValuePair<int, string> kvp in levelDetails.TileDictionary)
			{
				var componentData = ECSDatabase.GetComponentData(kvp.Value);
				var traitData = ECSDatabase.GetTraitData(kvp.Value);
				var tileEntityId = GetNewEntityId();

				GenerateComponents(tileEntityId, componentData, traitData);
				tileDictionary[kvp.Key] = tileEntityId;
			}

			for (int i = 0; i < levelDetails.TileGrid.Length; i++)
				levelDetails.TileGrid[i] = tileDictionary[levelDetails.TileGrid[i]];

			var mapComponent = new MapComponent(levelEntityId, levelDetails);
			AddComponent(levelEntityId, mapComponent);

			// TODO: Add all the other entities here.
			// TODO: Figure out where to put the Create Level Event.

			return levelEntityId;
		}
	}
}
