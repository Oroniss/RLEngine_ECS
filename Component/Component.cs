using System;
using System.Collections.Generic;

namespace ECS.Components
{
	[Serializable]
	public abstract class Component
	{
		static long maxComponentId = 1;

		ComponentType _componentType;
		long _componentId;
		int _entityId;

		protected Component(ComponentType componentType, int entityId)
		{
			_componentType = componentType;
			_componentId = maxComponentId;
			maxComponentId++;

			_entityId = entityId;
		}

		public long ComponentId
		{
			get { return _componentId; }
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
