using NUnit.Framework;
using ECS.GameSystems;
using System.Collections.Generic;

namespace ECS.Testing
{
	[TestFixture]
	public class SerialisationTests
	{
		[Test]
		public void TestSerialisation()
		{
			Components.ComponentData.ECSDatabase.SetParentFolder(System.IO.Path.Combine(
				TestContext.CurrentContext.TestDirectory, "Component", "ComponentData"));

			var paramDict1 = new Dictionary<string, string>
			{
				{"XLoc", "2"},
				{"YLoc", "1"},
				{"LevelName", "TestLevel1"}
			};

			var entityId1 = SystemProvider.EntitySystem.CreateEntity("TestEntity1", paramDict1);

			var paramDict2 = new Dictionary<string, string>
			{
				{"XLoc", "1"},
				{"YLoc", "0"},
				{"LevelName", "TestLevel1"}
			};

			var entityId2 = SystemProvider.EntitySystem.CreateEntity("TestEntity2", paramDict2);

			var paramDict3 = new Dictionary<string, string>
			{
				{"Material", "TestMaterial1"},
				{"XLoc", "3"},
				{"YLoc", "2"},
				{"LevelName", "TestLevel1"}
			};

			var entityId3 = SystemProvider.EntitySystem.CreateEntity("TestEntity3", paramDict3);

			var entityId4 = SystemProvider.EntitySystem.CreateEntity("TestEntity4", new Dictionary<string, string>());
			var entityId5 = SystemProvider.EntitySystem.CreateEntity("TestEntity4", new Dictionary<string, string>());

			var serialisationData = SystemProvider.EntitySystem.GetSerialisationData();
			SystemProvider.EntitySystem.LoadSerialisationData(serialisationData);

			Assert.IsTrue(SystemProvider.EntitySystem.IsValidEntityId(entityId5));
			Assert.IsFalse(SystemProvider.EntitySystem.IsValidEntityId(entityId5 + 1));

			Assert.IsTrue(SystemProvider.EntitySystem.HasComponent(entityId1, Components.ComponentType.Position));
			Assert.IsFalse(SystemProvider.EntitySystem.HasComponent(entityId1, Components.ComponentType.Background));

			var bgComponent = (Components.BackgroundComponent)SystemProvider.EntitySystem.GetComponent(
				entityId5, Components.ComponentType.Background);

			Assert.AreEqual("Grey", bgComponent.BackgroundColor);
			Assert.AreEqual("DarkGrey", bgComponent.FogColor);
			Assert.AreEqual(Components.BackgroundDisplayLayer.Tile, bgComponent.BackgroundDisplayLayer);

			var fgComponent = (Components.ForegroundComponent)SystemProvider.EntitySystem.GetComponent(
				entityId3, Components.ComponentType.Foreground);

			Assert.AreEqual("RedBrown", fgComponent.FGColor);
			Assert.AreEqual('#', fgComponent.Symbol);
			Assert.AreEqual(Components.ForegroundDisplayLayer.Furnishing, fgComponent.DisplayLayer);
		}
	}
}
