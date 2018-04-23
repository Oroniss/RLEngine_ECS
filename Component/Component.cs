using System;

namespace ECS.Components
{
	[Serializable]
	public abstract class Component
	{
		static long maxComponentId = 1;

		ComponentType _componentType;
		long _componentId;
		int _entityId;

		public Component(ComponentType componentType, int entityId)
		{
			_componentType = componentType;
			_componentId = maxComponentId;
			maxComponentId++;
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
	}
}
