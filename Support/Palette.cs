using System.Collections.Generic;
using RLNET;

namespace RLEngine.Support.Palette
{
	public static class Palette
	{
		public static Dictionary<string, RLColor> colors = new Dictionary<string, RLColor>
		{
			{"Black",                   new RLColor(0, 0, 0)},
			{"White",                   new RLColor(255, 255, 255)},
			{"Silver",                  new RLColor(190, 190, 190)}
		};

		public static RLColor GetColor(string colorName)
		{
			if (colors.ContainsKey(colorName))
				return colors[colorName];
			ErrorLogger.AddDebugText("Unknown color name: " + colorName);
			return colors["Black"];
		}
	}
}
