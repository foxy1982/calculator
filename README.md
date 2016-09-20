# DI - why?

A lot of the commercial work I’m involved with uses Dependency Injection, unit testing and method mocking.  Some developers aren’t familiar with these techniques though, and while it’s easy to say “this is how you write a unit test, this is how you do DI” etc. it can be less effective unless you know WHY you’re doing what you’re doing.  So I’ve put together this contrived and overengineered example to explain the WHY behind the HOW.  Just for the record, this isn’t how I’d normally write a calculator app… there are some things which are definitely pedantic and just not worth the effort, but life’s about the journey and not the destination right!?

### Stage 1: The template

That’s right, it’s a calculator!  Nothing much to see here.  The `Program.Main` method is responsible for handling user input and passes on whatever has been typed into the calculator.  This way we’ve abstracted the user interaction from the calculator, which is where we’re going to be spending time refactoring and Making Things Better.  At the moment the calculator isn’t easy to test and be sure you’ve covered most scenarios.

### Stage 2: Refactor the operators into their own classes
*Separation of Concerns & Extract Class*

The calculator class is a bit of a muddle of responsibility here so it’s time to apply the SRP - no. 1 of the SOLID acronym! We’ll pull out the actual calculation work so that the calculator is left with a single task - make the decision on which action to apply.  As a bonus, extract the query parsing logic too!

### Stage 3: Unit test the operators
*Unit testing*

The operators are not isolated classes so can easily be tested.  So get on with it.

### Stage 4: Remove the new keyword by introducing DI
*Extract Interface*

We still want to be able to test the decision logic in the calculator without testing the implementation of the operators.  This is extremely difficult while the calculator is building objects to handle the actual mathematical functions.

### Stage 5: Unit test the calculator
*Mocks*

Now we’re in a position to test that decision logic.  So get on with it!

### Stage 6: Introduce Unity
*DI Container*

We’re now creating the structure of our project in a bootstrap method of the main `Program`, and explicitly specifying how to create our dependencies and finally the calculator itself.  There is another way though… use a DI container to manage this work for you.
