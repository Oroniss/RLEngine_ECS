// Updated for ECS version 1.0.

using System.Collections.Generic;

namespace ECS
{
	public static class ErrorLogger
	{
		static bool testMode;
		static List<string> testMessages;

		public static void AddDebugText(string debugText)
		{
			AddDebugText(debugText, "White");
		}

		public static void AddDebugText(string debugText, string color)
		{
			if (testMode)
			{
				testMessages.Add(debugText);
			}
			else
			{
				System.Console.WriteLine(debugText + ", " + color);
			}
		}

		public static void SetToTest()
		{
			testMode = true;
			testMessages = new List<string>();
		}

		public static string GetNextMessage()
		{
			if (testMessages.Count == 0)
				return "";
			var nextMessage = testMessages[0];
			testMessages.RemoveAt(0);
			return nextMessage;
		}
	}
}
