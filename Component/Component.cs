// Revised for ECS version 1.0.

using System;
using System.Collections.Generic;

namespace RLEngine.Components
{
	[Serializable]
	public abstract class Component
	{
		ComponentType _componentType;
		int _entityId;

		protected Component(ComponentType componentType, int entityId)
		{
			_componentType = componentType;
			_entityId = entityId;
		}

		public int EntityId
		{
			get { return _entityId; }
		}

		public ComponentType componentType
		{
			get { return _componentType; }
		}

		protected string GetStringParameter(string parameterName, Dictionary<string, string> parameterDictionary)
		{
			if (parameterDictionary.ContainsKey(parameterName))
				return parameterDictionary[parameterName];
			ErrorLogger.AddDebugText(string.Format("Parameter dictionary for {0} did not contain parameter name {1}",
			                                       parameterDictionary["EntityName"], parameterName));
			return "";
		}

		protected int GetIntParameter(string parameterName, Dictionary<string, string> parameterDictionary)
		{
			if (parameterDictionary.ContainsKey(parameterName))
				return int.Parse(parameterDictionary[parameterName]);
			ErrorLogger.AddDebugText(string.Format("Parameter dictionary for {0} did not contain parameter name {1}",
												   parameterDictionary["EntityName"], parameterName));
			return 0;
		}
	}
}
