using System;

namespace ECS.Components
{
	[Serializable]
	public class ForegroundComponent:Component
	{
		char _symbol;
		string _fgColor;
		ForegroundDisplayLayer _displayLayer;

		public ForegroundComponent(int entityId, char symbol, string fgColor, ForegroundDisplayLayer layer)
			:base(ComponentType.Foreground, entityId)
		{
			_symbol = symbol;
			_fgColor = fgColor;
			_displayLayer = layer;
		}

		public char Symbol
		{
			get { return _symbol; }
		}

		public string FGColor
		{
			get { return _fgColor; }
		}

		public ForegroundDisplayLayer DisplayLayer
		{
			get { return _displayLayer; }
		}
	}

	public enum ForegroundDisplayLayer
	{
		Furnishing,
		Actor,
		Player,
		Interface
	}
}
