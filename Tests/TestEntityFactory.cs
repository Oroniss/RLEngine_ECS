/*
 * This could reasonably go in the EntitySystem tests as well, but since it is pretty specific
 * and also pretty large, it's getting it's own test class.
 * 
 * May eventually include tests of other entity types as well - level, quest, etc.
 */

// Updated for ECS Version 1.0.

using NUnit.Framework;
using ECS.GameSystems;
using System.Collections.Generic;

namespace ECS.Testing
{
	[TestFixture]
	public class TestEntityFactory
	{
		[Test]
		public void TestCreateEntity()
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

			Assert.IsTrue(SystemProvider.EntitySystem.HasComponent(entityId1, Components.ComponentType.Position));
			Assert.IsTrue(SystemProvider.EntitySystem.HasComponent(entityId1, Components.ComponentType.Foreground));
			Assert.IsTrue(SystemProvider.EntitySystem.HasTrait(entityId1, Components.Trait.BlockMove));
			Assert.IsFalse(SystemProvider.EntitySystem.HasComponent(entityId1, Components.ComponentType.Background));
			Assert.IsFalse(SystemProvider.EntitySystem.HasTrait(entityId1, Components.Trait.BlockLOS));

			var positionComponent = (Components.PositionComponent)SystemProvider.EntitySystem.GetComponent(entityId1, 
			                                    Components.ComponentType.Position);

			Assert.AreEqual(2, positionComponent.XLoc);
			Assert.AreEqual(1, positionComponent.YLoc);
			Assert.AreEqual("TestLevel1", positionComponent.LevelName);

			var entityId2 = SystemProvider.EntitySystem.CreateEntity("TestEntity4", new Dictionary<string, string>());

			Assert.IsTrue(SystemProvider.EntitySystem.HasComponent(entityId2, Components.ComponentType.Background));
			Assert.IsFalse(SystemProvider.EntitySystem.HasComponent(entityId2, Components.ComponentType.Foreground));
			Assert.IsFalse(SystemProvider.EntitySystem.HasTrait(entityId2, Components.Trait.BlockLOS));

			var paramDict2 = new Dictionary<string, string>
			{
				{"Material", "TestMaterial1"},
				{"XLoc", "0"},
				{"YLoc", "2"},
				{"LevelName", "TestLevel1"}
			};

			var entityId3 = SystemProvider.EntitySystem.CreateEntity("TestEntity3", paramDict2);

			Assert.IsTrue(SystemProvider.EntitySystem.HasTrait(entityId3, Components.Trait.Wood));

			var fgComponent = (Components.ForegroundComponent)SystemProvider.EntitySystem.GetComponent(entityId3,
			                              Components.ComponentType.Foreground);

			Assert.AreEqual("RedBrown", fgComponent.FGColor);
			Assert.AreEqual('#', fgComponent.Symbol);
			Assert.AreEqual(Components.ForegroundDisplayLayer.Furnishing, fgComponent.DisplayLayer);
		}
	}
}
