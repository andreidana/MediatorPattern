# MediatorPattern

**Definition** 

Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.

**Applicability**

Use the Mediator pattern when 

- a set of objects communicate in well-defined but complex ways. The resulting inter dependencies are unstructured and difficult to understand.  
- reusing an object is difficult because it refers to and communicates with many other objects.  
- a behavior that's distributed between several classes should be customizable without a lot of subclassing.

**Consequences**

- It limits subclassing.
- It decouples colleagues.
- It simplifies object protocols.
- It abstracts how objects cooperate.
- It centralizes control


**Related Patterns**

- [Facade](https://github.com/andreidana/FacadeExample)
- Observer