using NUnit.Framework;
using System.IO;
using ECS.Components.ComponentData;

namespace ECS.Testing
{
	[TestFixture]
	public class TestComponentDatabase
	{
		[Test]
		public void TestReadData()
		{
			ECSDatabase.SetParentFolder(Path.Combine(TestContext.CurrentContext.TestDirectory, "Component", "ComponentData"));
			var data = ECSDatabase.GetComponentData("TestEntity1");
		}

		[Test]
		public void TestComponentTypes()
		{
			ECSDatabase.SetParentFolder(Path.Combine(TestContext.CurrentContext.TestDirectory, "Component", "ComponentData"));

			var entity1Data = ECSDatabase.GetComponentData("TestEntity1");
			Assert.IsTrue(entity1Data.ContainsKey("ForegroundComponent"));
			Assert.IsTrue(entity1Data.ContainsKey("PositionComponent"));
			Assert.IsFalse(entity1Data.ContainsKey("BackgroundComponent"));

			var entity2data = ECSDatabase.GetComponentData("TestEntity3", "TestMaterial1");
			Assert.IsTrue(entity2data.ContainsKey("ForegroundComponent"));
			Assert.IsTrue(entity2data.ContainsKey("PositionComponent"));
			Assert.IsFalse(entity2data.ContainsKey("BackgroundComponent"));

			var entity3Data = ECSDatabase.GetComponentData("TestEntity4");
			Assert.IsTrue(entity3Data.ContainsKey("BackgroundComponent"));
			Assert.IsFalse(entity3Data.ContainsKey("ForegroundComponent"));
			Assert.IsFalse(entity3Data.ContainsKey("PositionComponent"));
		}

		[Test]
		public void TestBackgroundComponentData()
		{
			ECSDatabase.SetParentFolder(Path.Combine(TestContext.CurrentContext.TestDirectory, "Component", "ComponentData"));

			var entity1Data = ECSDatabase.GetComponentData("TestEntity4");
			Assert.IsTrue(entity1Data.ContainsKey("BackgroundComponent"));
			Assert.AreEqual("Grey", entity1Data["BackgroundColor"]);
			Assert.AreEqual("DarkGrey", entity1Data["FogColor"]);
			Assert.AreEqual("Tile", entity1Data["BackgroundDisplayLayer"]);

			var entity2Data = ECSDatabase.GetComponentData("TestEntity5");
			Assert.IsTrue(entity2Data.ContainsKey("BackgroundComponent"));
			Assert.AreEqual("Blue", entity2Data["BackgroundColor"]);
			Assert.AreEqual("DarkBlue", entity2Data["FogColor"]);
			Assert.AreEqual("Tile", entity2Data["BackgroundDisplayLayer"]);
		}

		[Test]
		public void TestForegroundComponentData()
		{
			ECSDatabase.SetParentFolder(Path.Combine(TestContext.CurrentContext.TestDirectory, "Component", "ComponentData"));

			var entity1Data = ECSDatabase.GetComponentData("TestEntity1");
			Assert.IsTrue(entity1Data.ContainsKey("ForegroundComponent"));
			Assert.AreEqual("Orange", entity1Data["ForegroundColor"]);
			Assert.AreEqual("g", entity1Data["Symbol"]);
			Assert.AreEqual("Actor", entity1Data["ForegroundDisplayLayer"]);

			var entity2Data = ECSDatabase.GetComponentData("TestEntity3");
			Assert.IsTrue(entity2Data.ContainsKey("ForegroundComponent"));
			Assert.AreEqual("#", entity2Data["Symbol"]);
			Assert.AreEqual("Furnishing", entity2Data["ForegroundDisplayLayer"]);
		}

		[Test]
		public void TestTraitData()
		{
			ECSDatabase.SetParentFolder(Path.Combine(TestContext.CurrentContext.TestDirectory, "Component", "ComponentData"));

			var entity1Traits = ECSDatabase.GetTraitData("TestEntity1");
			Assert.IsTrue(entity1Traits.Contains(Components.Trait.BlockMove));
			Assert.IsFalse(entity1Traits.Contains(Components.Trait.BlockLOS));

			var entity2Traits = ECSDatabase.GetTraitData("TestEntity3", "TestMaterial1");
			Assert.IsTrue(entity2Traits.Contains(Components.Trait.BlockLOS));
			Assert.IsTrue(entity2Traits.Contains(Components.Trait.BlockMove));
			Assert.IsTrue(entity2Traits.Contains(Components.Trait.Wood));

			var entity3Traits = ECSDatabase.GetTraitData("TestEntity4");
			Assert.AreEqual(0, entity3Traits.Count);
		}

		[Test]
		public void TestComponentDatabaseErrorHandling()
		{
			// Intentionally not testing the bad file formats, since I don't think it's worth adding to the project for it.

			ECSDatabase.SetParentFolder(Path.Combine(TestContext.CurrentContext.TestDirectory, "Component", "ComponentData"));
			ErrorLogger.SetToTest();

			var badEntityData = ECSDatabase.GetComponentData("Not an Entity!!!");
			Assert.AreEqual(0, badEntityData.Count);
			Assert.AreEqual("Couldn't find entity Not an Entity!!! in data file", ErrorLogger.GetNextMessage());
		}
	}
}
