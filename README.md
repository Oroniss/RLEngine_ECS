# ECS Framework

Creating an ECS framework with the intention of having something that can be easily re-used across different games in the future (or potentially even other projects as well).

It is written in C# - but it might be worth investigating porting it to Python at some stage as well.

Major sections are:

* Components: - largely intended to be just data objects but some may have functionality where it is logically self-contained, especially regarding data validation/consistency, etc.
* Entities: - are just an integer that relates different components to each other.
* Systems: - classes that iterate of components or groups of components and update/change state.
* Events: - certain events that interact with groups, i.e. add component, remove component, etc.

There is also a "test" module using NUnit.

Some design decisions:

The current intention is that all actions that change component data should be captured in a GameEvent.
This would allow game events essentially to be used to store a log of the game.

In terms of the data storage - Components are only stored in a single place - the EntitySystem.
All other locations just store a reference to the entity in question.

GameSystems should only store "meta-data", or "derived data". In other words, data that can be reconstructed from the component data
if required. This limits serialisation to the component data, reduces the chance of inconsistency in component data, and
still allows systems to store what they need for fast access/update.
