using System;
using System.Collections.Generic;

namespace ECS.Components
{
	[Serializable]
	public class ForegroundComponent:Component
	{
		char _symbol;
		string _fgColor;
		ForegroundDisplayLayer _foregroundDisplayLayer;

		public ForegroundComponent(int entityId, char symbol, string fgColor, ForegroundDisplayLayer foregroundLayer)
			:base(ComponentType.Foreground, entityId)
		{
			_symbol = symbol;
			_fgColor = fgColor;
			_foregroundDisplayLayer = foregroundLayer;
		}

		public ForegroundComponent(int entityId, Dictionary<string, string> otherParameters)
			:base(ComponentType.Foreground, entityId)
		{
			_symbol = GetStringParameter("Symbol", otherParameters)[0];
			_fgColor = GetStringParameter("FgColor", otherParameters);
			_foregroundDisplayLayer = (ForegroundDisplayLayer)Enum.Parse(typeof(ForegroundDisplayLayer),
												 GetStringParameter("ForegroundDisplayLayer", otherParameters));
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
			get { return _foregroundDisplayLayer; }
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
