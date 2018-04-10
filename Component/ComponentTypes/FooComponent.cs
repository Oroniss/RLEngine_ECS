using System;

namespace ECS.Components
{
	[Serializable]
	public class FooComponent:Component
	{
		int _aNumber;
		string _someText;

		public FooComponent(int aNumber, string someText)
			:base(ComponentType.Foo)
		{
			_aNumber = aNumber;
			_someText = someText;
		}

		public int ANumber
		{
			get { return _aNumber; }
		}

		public string SomeText
		{
			get { return _someText; }
		}
	}
}
