1. Why did you use inheritance?
I used inheritance because all of them actually share a common identity as a vehicle. It helps to just use the same code from a single code.

2. Why did you use interfaces?
I used interfaces to give a specific actions for different transport.

3. Could Helicopter inherit from both Vehicle and Airplane? Why or why not?
For me its a no since C# can't take a multiple inheritance.

4. Why can Helicopter implement both IFlyable and IDriveable?
Helicopter can implement both IFlyable and IDriveable since its from interfaces. C# allows a class to connect in many interfaces as many as it needs. 

5. If a Submarine can both sail and dive, how would you design it?
I will make the Submarine class inherit from the main vehicle class too then create a new class inside the interfaces called "IDiveable.cs". Then I'll implement a two interfaces in submarine class which is Isailable and IDiveable.
