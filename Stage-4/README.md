# Stage 4: Test the operators
*Extract Interface*

We still want to be able to test the decision logic in the calculator without testing the implementation of the operators.  This is extremely difficult while the calculator is building objects to handle the actual mathematical functions.

In the last stage we added unit tests around the calculator operations.  This area of the codebase is nicely covered now.  There's still the decision logic to handle though.  This is in `Calculator.Calculate`.

At the moment it is very difficult to test the decision logic without also testing the implementation of the operations themselves.  This is because of the `new` keyword being used to create each of the operators when a decision is made (it is also used to create a `QueryParser`).

We can remove the `new` keyword by extracting an interface from the operators and injecting the implementation in the constructor of the `Calculator` class.  This means that the decision logic won't create any new objects, so we won't be reliant on understanding the content of the operators in order to test that the correct operator is executed.

For each of the operators and the `QueryParser`, create a dedicated interface (`IMultiplier`, `IQueryParser` etc), and add a private property for each of the interfaces to the `Calculator` class.  These properties should be initialised in the constructor of `Calculator`.

You'll also need to update the `Program` class to pass in the implementation for each interface in the constructor of `Calculator`.  This time we can use the `new` keyword as we're not planning on putting tests around `Program`.  You might want to extract the creation of the `Calculator` into a new `Bootstrap` method.

Don't forget to run your unit tests when you're done!
