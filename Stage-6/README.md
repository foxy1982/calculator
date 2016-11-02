# Stage 6: Introduce Unity
*Dependency Injection Container*

The `Bootstrap` method in the `Program` class is really a definition of how we want our classes to interact.  It's quite simple in this example... it just creates instances of our operators and passes them into the constructor of `Calculator`.  It's easy to see that the `Calculator` is dependent on our four operators.

When working with a bigger and more complex system this approach may not work as well.  There might be multiple classes that want an instance of `Subtractor`.  They may be happy to share an instance with other classes or they could require their own instance.  Our `Calculator` may be a dependency of another class.  There could be a huge amount of complexity to manage here.

This is where a [Dependency Injection](http://www.martinfowler.com/articles/injection.html) container can be useful.  It will manage the wiring of objects up.  It will manage the lifetime of objects it creates.  This can be particularly useful in a web application where you might want an object to just have a lifetime in line with the current web request you're handling.

In our case, instead of telling the program how to create the `Calculator` class in the `Bootstrap` method, we tell our DI container how to create it and when we're ready to use it, we ask our container to create the object.  It then analyses the constructor of the object you've asked to create and it will work out how it can construct an instance for you.

It's worth mentioning that there are many things that DI containers can do as well as the constructor injection feature we're using here.  There are also different ways to configure a container such as in-code, config or even let it determine relationships by class name conventions.  I'm a fan of the code approach for clarity, and personally would avoid using the naming convention technique for the same reason.

There are quite a few different containers that you can use in .NET.  Some are quite heavyweight, some are much more simple.  My preferred container is [Unity](https://msdn.microsoft.com/en-us/library/dn223671.aspx) as I've found it has the best balance between a rich feature set and simplicity of use.

Only two things change in this section... install Unity via NuGet, and update the `Program` class to configure and use the Unity container.  We need to register each of our operators with Unity against the interface using the `RegisterType` method.  We need to tell Unity about the `Calculator` class itself too.  Finally we need to ask Unity to create a `Calculator` by calling `Resolve`.
