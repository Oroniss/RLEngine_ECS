using System;

namespace ECS.Components
{
	[Serializable]
	public abstract class Component
	{
		static long maxComponentId = 1;


		ComponentType _componentType;
		long _id;

		public Component(ComponentType componentType)
		{
			_componentType = componentType;
			_id = maxComponentId;
			maxComponentId++;
		}

		public long ComponentId
		{
			get { return _id; }
		}

		public ComponentType componentType
		{
			get { return _componentType; }
		}
	}
}
