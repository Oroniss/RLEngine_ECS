// Updated for ECS version 1.0.

using NUnit.Framework;
using RLEngine.Components;
using System.Collections.Generic;

namespace RLEngine
{
	[TestFixture]
	public class ComponentTests
	{
		[Test]
		public void TestBaseComponent()
		{
			var testComponent = new PositionComponent(0, 5, 5, "TestLevel1");
			Assert.AreEqual(0, testComponent.EntityId);
		}

		[Test]
		public void TestPositionComponent()
		{
			var testComponent1 = new PositionComponent(0, 5, 10, "TestLevel1");

			Assert.AreEqual(5, testComponent1.XLoc);
			Assert.AreEqual(10, testComponent1.YLoc);
			Assert.AreEqual("TestLevel1", testComponent1.LevelName);
			Assert.AreEqual(ComponentType.Position, testComponent1.componentType);

			var paramDict = new Dictionary<string, string> {
				{"EntityName", "TestEntity"},
				{"XLoc", "5" },
				{"YLoc", "10"},
				{"LevelName", "TestLevel1"}};

			var testComponent2 = new PositionComponent(0, paramDict);

			Assert.AreEqual(5, testComponent2.XLoc);
			Assert.AreEqual(10, testComponent2.YLoc);
			Assert.AreEqual("TestLevel1", testComponent2.LevelName);
			Assert.AreEqual(ComponentType.Position, testComponent2.componentType);

			testComponent2.UpdatePosition(7, 8);

			Assert.AreEqual(7, testComponent2.XLoc);
			Assert.AreEqual(8, testComponent2.YLoc);
		}

		[Test]
		public void TestForegroundComponent()
		{
			var testComponent1 = new ForegroundComponent(0, '$', "LightBlue", ForegroundDisplayLayer.Furnishing);

			Assert.AreEqual('$', testComponent1.Symbol);
			Assert.AreEqual("LightBlue", testComponent1.FGColor);
			Assert.AreEqual(ForegroundDisplayLayer.Furnishing, testComponent1.DisplayLayer);
			Assert.AreEqual(ComponentType.Foreground, testComponent1.componentType);

			var paramDict = new Dictionary<string, string> {
				{"EntityName", "TestEntity"},
				{"Symbol", "$" },
				{"ForegroundColor", "LightBlue"},
				{"ForegroundDisplayLayer", "Furnishing"}};

			var testComponent2 = new ForegroundComponent(0, paramDict);

			Assert.AreEqual('$', testComponent2.Symbol);
			Assert.AreEqual("LightBlue", testComponent2.FGColor);
			Assert.AreEqual(ForegroundDisplayLayer.Furnishing, testComponent2.DisplayLayer);
			Assert.AreEqual(ComponentType.Foreground, testComponent2.componentType);
		}

		[Test]
		public void TestBackgroundComponent()
		{
			var testComponent1 = new BackgroundComponent(0, "DarkBrown", "NightBrown", BackgroundDisplayLayer.Tile);

			Assert.AreEqual("DarkBrown", testComponent1.BackgroundColor);
			Assert.AreEqual("NightBrown", testComponent1.FogColor);
			Assert.AreEqual(BackgroundDisplayLayer.Tile, testComponent1.BackgroundDisplayLayer);

			var paramDict = new Dictionary<string, string> {
				{"EntityName", "TestEntity"},
				{"BackgroundColor", "DarkBrown" },
				{"FogColor", "NightBrown"},
				{"BackgroundDisplayLayer", "Tile"}};

			var testComponent2 = new BackgroundComponent(0, paramDict);

			Assert.AreEqual("DarkBrown", testComponent2.BackgroundColor);
			Assert.AreEqual("NightBrown", testComponent2.FogColor);
			Assert.AreEqual(BackgroundDisplayLayer.Tile, testComponent2.BackgroundDisplayLayer);
		}

		[Test]
		public void TestMapComponent()
		{
			int[] tileGrid = {0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 1 };

			var testComponent1 = new MapComponent(2, 4, 3, tileGrid);

			Assert.AreEqual(4, testComponent1.Width);
			Assert.AreEqual(3, testComponent1.Height);

			Assert.AreEqual(0, testComponent1.GetMapTile(0, 0));
			Assert.AreEqual(0, testComponent1.GetMapTile(3, 1));
			Assert.AreEqual(1, testComponent1.GetMapTile(2, 1));
			Assert.AreEqual(1, testComponent1.GetMapTile(0, 2));

			string tileGrid2 = "0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 1";

			var paramDict = new Dictionary<string, string> {
				{"EntityName", "TestEntity"},
				{"MapWidth", "4" },
				{"MapHeight", "3"},
				{"TileGrid", tileGrid2}};

			var testComponent2 = new MapComponent(2, paramDict);

			Assert.AreEqual(4, testComponent2.Width);
			Assert.AreEqual(3, testComponent2.Height);

			Assert.AreEqual(0, testComponent2.GetMapTile(0, 0));
			Assert.AreEqual(0, testComponent2.GetMapTile(3, 1));
			Assert.AreEqual(1, testComponent2.GetMapTile(2, 1));
			Assert.AreEqual(1, testComponent2.GetMapTile(0, 2));
		}

		[Test]
		public void TestComponentErrorHandling()
		{
			ErrorLogger.SetToTest();

			var paramDict = new Dictionary<string, string> {
				{"EntityName", "TestEntity"}};

			var testComponent = new PositionComponent(0, paramDict);

			Assert.AreEqual("Parameter dictionary for TestEntity did not contain parameter name XLoc", 
			                ErrorLogger.GetNextMessage());
			Assert.AreEqual("Parameter dictionary for TestEntity did not contain parameter name YLoc",
							ErrorLogger.GetNextMessage());
			Assert.AreEqual("Parameter dictionary for TestEntity did not contain parameter name LevelName",
							ErrorLogger.GetNextMessage());
		}
	}
}
