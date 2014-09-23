CityAutomata
============

_CityAutomata_ is an abstract city simulator.  In principle, it's inspired by the [SimCity](https://en.wikipedia.org/wiki/SimCity) line of video games as well as [John Conway](https://en.wikipedia.org/wiki/John_Horton_Conway)'s [Game of Life](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life).  But it's neither of those, really.  Instead, the idea is to evolve a sort of generic city based on its geometry and basic rules.

The short version is that, each turn, the program calculates the value of living on each block in the city and the cost to develop the property further.  The difference between value and cost determines how desirable it is to live there, and therefore how many people try to move in or out.

What is _CityAutomata_ for?  Not much, really.  After the basic implementation is complete, I would like to add in rules that represent zoning and [architectural design patterns](https://en.wikipedia.org/wiki/Pattern_%28architecture%29).  That should produce cities that appear economically plausible while still being potentially aesthetically pleasing.

But until that happens, it just shows the likely population distribution in a generic city.

