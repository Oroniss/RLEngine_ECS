using System;

namespace ECS.Components
{
	[Serializable]
	public class BarComponent:Component
	{
		string[] _arrayOfStuff;

		public BarComponent(string[] arrayOfStuff)
			:base(ComponentType.Bar)
		{
			_arrayOfStuff = arrayOfStuff;
		}

		public string[] ArrayOfStuff
		{
			get { return _arrayOfStuff; }
		}
	}
}
