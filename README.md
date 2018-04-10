# ECS Framework

Creating an ECS framework with the intention of having something that can be easily re-used across different games in the future (or potentially even other projects as well).

It is written in C# - but it might be worth investigating porting it to Python at some stage as well.

Major sections are:

* Components: - largely intended to be just data objects but some may have functionality where it is logically self-contained, especially regarding data validation/consistency, etc.
* Entities: - just component lists - each entity is just a Component[].
* Systems: - classes that iterate of components or groups of components and update/change state.
* Groups: - collections of component types that are tracked to allow systems to easily get relevant entities.
* Events: - certain events that interact with groups, i.e. add component, remove component, etc.

There is also a "test" module using NUnit.
