#  Stage 2: Refactor the operators into their own classes
*Separation of Concerns & Extract Class*

Although the user interaction is in the `Program` class, there's still a lot of different jobs that the `Calculator` class is doing; it's parsing the input, deciding which operation to apply and calculating the result.  This is a breach of the [Single Responsibility Principle](https://8thlight.com/blog/uncle-bob/2014/05/08/SingleReponsibilityPrinciple.html) which is part of the [SOLID](http://www.blackwasp.co.uk/SOLID.aspx) set of principles.

The changes in this stage are to take the operators and move each of them into their own class using [Extract Class](http://refactoring.com/catalog/extractClass.html).  The operators at the moment are in the `Calculator.Calculate` method.  This method should be changed to create new instances of the new operator classes, and call the relevant method to do the calculation.

While we're at it, we can also move the code that parses the input query into a `QueryParser` class.  Final example after these refactors can be found in this folder.
