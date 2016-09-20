# Stage 3: Test the operators
*Unit testing*

Now that the operators are in their own classes, it becomes very easy to wrap unit tests around them.  The unit tests are very simple as the operators have no dependencies themselves.  You can also easily test the `QueryParser` class now that the code is extracted from `Calculator`.

There are a few unit test frameworks with .NET, such as [MSTest](https://msdn.microsoft.com/en-us/library/ms243147.aspx), [nUnit](http://www.nunit.org/) and [xUnit](https://xunit.github.io/).  MSTest is the inbuilt Visual Studio test system so it's very easy to get started with.  Personally I'm a fan of nUnit as I find it works well with third-party tools such as the excellent [Resharper](https://www.jetbrains.com/resharper/).

I also like using [FluentAssertions](http://www.fluentassertions.com/) just to make the intent of the test a bit more obvious.

For this exercise I've put the unit tests in the same assembly as the code that they're testing.  In a production environment you may not want to ship your tests, in which case they can easily be created in a dedicated test assembly.

It's worth mentioning here that this isn't [Test Driven Development (TDD)](https://www.tutorialspoint.com/software_testing_dictionary/test_driven_development.htm).  TDD is about writing tests first and then writing the logic that meets the criteria defined by the tests.  This exercise is about wrapping tests around existing functionality to capture behaviour.
