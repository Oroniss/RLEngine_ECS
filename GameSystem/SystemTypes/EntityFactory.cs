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
			if (otherParameters.ContainsKey("material"))
			{
				allParameters = CombineParameterDictionaries(otherParameters,
					   ECSDatabase.GetComponentData(entityName, otherParameters["material"]));
				allTraits = ECSDatabase.GetTraitData(entityName, otherParameters["material"]);
			}
			else
			{
				allParameters = CombineParameterDictionaries(otherParameters,
						   ECSDatabase.GetComponentData(entityName));
				allTraits = ECSDatabase.GetTraitData(entityName);
			}

			// TODO: Setup all the components here.

			foreach (Trait trait in allTraits)
				AddTrait(newEntityId, trait);

			return newEntityId;	
		}


	}

}
