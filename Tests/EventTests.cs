// Updated for ECS version 1.0.

using NUnit.Framework;
using ECS.GameEvents;

namespace ECS.Testing
{
	[TestFixture]
	public class EventTests
	{
		[Test]
		public void TestGameEvent()
		{
			var testSystem = new TestSystem();

			CreateEntityEvent.NewCreateEntityEvent(0);
			GameEvent.ProcessEvents();

			var gameEvent = testSystem.GetNextEvent();

			Assert.AreEqual(EventType.CreateEntity, gameEvent.EventType);
		}

		[Test]
		public void TestCreateEntityEvent()
		{
			var testSystem = new TestSystem();

			CreateEntityEvent.NewCreateEntityEvent(1);
			GameEvent.ProcessEvents();

			var gameEvent = (CreateEntityEvent)testSystem.GetNextEvent();

			Assert.AreEqual(EventType.CreateEntity, gameEvent.EventType);
			Assert.AreEqual(1, gameEvent.EntityId);
		}

		[Test]
		public void TestMoveEntityEvent()
		{
			var testSystem = new TestSystem();

			MoveEntityEvent.NewMovementEvent(1, 5, 6, 8, 4);
			GameEvent.ProcessEvents();

			var gameEvent = (MoveEntityEvent)testSystem.GetNextEvent();

			Assert.AreEqual(1, gameEvent.EntityId);
			Assert.AreEqual(5, gameEvent.OldX);
			Assert.AreEqual(6, gameEvent.OldY);
			Assert.AreEqual(8, gameEvent.NewX);
			Assert.AreEqual(4, gameEvent.NewY);
		}

		[Test]
		public void TestEventErrorHandling()
		{
			// TODO: Add here as more stuff comes on line.
		}
	}
}
