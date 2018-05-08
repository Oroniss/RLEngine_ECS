using System;
using System.Collections.Generic;
using ECS.Components;
using ECS.Components.ComponentData;

namespace ECS.GameSystems
{
	[Serializable]
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

			if (allParameters.ContainsKey("BackgroundComponent"))
			{
				var component = new BackgroundComponent(newEntityId, allParameters);
				AddComponent(newEntityId, component);
			}

			if (allParameters.ContainsKey("ForegroundComponent"))
			{
				var component = new ForegroundComponent(newEntityId, allParameters);
				AddComponent(newEntityId, component);
			}

			if (allParameters.ContainsKey("MapComponent"))
			{
				var component = new MapComponent(newEntityId, allParameters);
				AddComponent(newEntityId, component);
			}

			if (allParameters.ContainsKey("PositionComponent"))
			{
				var component = new PositionComponent(newEntityId, allParameters);
				AddComponent(newEntityId, component);
			}

			// TODO: Setup all the components here.

			foreach (Trait trait in allTraits)
				AddTrait(newEntityId, trait);

			GameEvents.CreateEntityEvent.NewCreateEntityEvent(newEntityId);

			return newEntityId;	
		}
	}
}
