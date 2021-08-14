## Design Principle

<i><b>The Strategy Pattern</b> defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.</i>

This app is using the Strategy Pattern to implement the various behaviors of ducks. Therefore, the duck behavior has been encapsulated into its own set of classes that can be easily expanded and changed, even at runtime if needed.

<br />

> Identify the aspects of your application that vary and separate them from what stays the same

In other words, if you’ve got some aspect of your code that is changing, say with every new requirement, then you know you’ve got a behavior that needs to be pulled out and separated from all the stuff that doesn’t change.

Here’s another way to think about this principle: take the parts that vary and encapsulate them, so that later you can alter or extend the parts that vary without affecting those that don’t.

As simple as this concept is, it forms the basis for almost every design pattern. All patterns provide a way to let some part of a system vary independently of all other parts.

> Program to an interface, not an implementation
