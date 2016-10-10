# Stage 5: Unit test the calculator
*Mocks*

We've now isolated the decision logic from the implementation of the operators, which makes it easier to test.  The problem is that we still need something to test against to check we called the right thing.  The test we want to write is something along the lines of:

*Given the input is "8 x 4", we should call `Multiply` with 8 and 4"*

Bring On The Mocks...

A mock framework is a tool that allows you to create an object that conforms to an interface.  You can call it, check it was called, give it return values - basically you control how it behaves.  There are some subtleties around what a "mock" is and what a "stub" is... it's beyond the scope of this article to discuss this, but if you're interested then try starting [here](http://martinfowler.com/articles/mocksArentStubs.html#TheDifferenceBetweenMocksAndStubs).

In our case, for a given input, we're going to do two things - call `IQueryParser` and call an operator.  These are two separate tasks so should have separate tests.  I'd expect a test to check that the right call was made to `IQueryParser`.  I'd then expect a few tests for the operators, making sure they are called when `IQueryParser` responds with the right `Calculation`.  Note that because we're not using the real `QueryParser` we'll be able to take any input and configure our `IQueryParser` mock to return whichever `Calculation` suits our tests.

My favourite mock framework for .NET is [RhinoMocks](https://www.hibernatingrhinos.com/oss/rhino-mocks).  Other mock frameworks are available and I can't really comment on them as I don't really have the experience to contrast and compare them fairly.

Once you're done, you should have a comprehensive set of unit tests covering everything apart from `Program`, and the only code in here should by processing user input and bootstrapping the application.

I've used the `nUnit` test setup feature by adding the `SetUp` attribute to a method in the `CalculatorTests` class.  This method will be run before each test, allowing me to clean down and rebuild our test system.
