// Revised for ECS version 1.0.

using System;
using System.Collections.Generic;

namespace RLEngine.Components
{
	[Serializable]
	public class BackgroundComponent:Component
	{
		string _backgroundColor;
		string _fogColor;
		BackgroundDisplayLayer _backgroundDisplayLayer;

		public BackgroundComponent(int entityId, string backgroundColor, string fogColor, 
		                           BackgroundDisplayLayer backgroundLayer)
			:base(ComponentType.Background, entityId)
		{
			_backgroundColor = backgroundColor;
			_fogColor = fogColor;
			_backgroundDisplayLayer= backgroundLayer;
		}

		public BackgroundComponent(int entityId, Dictionary<string, string> otherParameters)
			:base(ComponentType.Background, entityId)
		{
			_backgroundColor = GetStringParameter("BackgroundColor", otherParameters);
			_fogColor = GetStringParameter("FogColor", otherParameters);
			_backgroundDisplayLayer = (BackgroundDisplayLayer)Enum.Parse(typeof(BackgroundDisplayLayer),
												 GetStringParameter("BackgroundDisplayLayer", otherParameters));
		}

		public string BackgroundColor
		{
			get { return _backgroundColor; }
		}

		public string FogColor
		{
			get { return _fogColor; }
		}

		public BackgroundDisplayLayer BackgroundDisplayLayer
		{
			get { return _backgroundDisplayLayer; }
		}
	}

	public enum BackgroundDisplayLayer
	{
		Tile,
		Furnishing,
		Misc
	}
}
