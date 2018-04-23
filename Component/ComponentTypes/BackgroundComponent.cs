using System;

namespace ECS.Components
{
	[Serializable]
	public class BackgroundComponent:Component
	{
		string _backgroundColor;
		string _fogColor;
		BackgroundDisplayLayer _displayLayer;

		public BackgroundComponent(int entityId, string backgroundColor, string fogColor, BackgroundDisplayLayer layer)
			:base(ComponentType.Background, entityId)
		{
			_backgroundColor = backgroundColor;
			_fogColor = fogColor;
			_displayLayer= layer;
		}

		public string BackgroundColor
		{
			get { return _backgroundColor; }
		}

		public string FogColor
		{
			get { return _fogColor; }
		}

		public BackgroundDisplayLayer DisplayLayer
		{
			get { return _displayLayer; }
		}
	}

	public enum BackgroundDisplayLayer
	{
		Tile,
		Furnishing,
		Misc
	}
}
