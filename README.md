# C# Reference Type Bug

This repository demonstrates a subtle bug related to the handling of reference types in C#.  The example showcases how modifying one variable referencing an object can unexpectedly alter another variable referencing the same object.

## Bug Description
The provided C# code creates two variables, `obj1` and `obj2`, both referencing the same instance of `ExampleClass`. When a property of `obj2` is modified, the same property of `obj1` also changes due to the shared memory reference. This behavior might be unexpected for developers unfamiliar with reference type semantics. 

## Bug Solution
The solution demonstrates how to create a true copy of the object using the `MemberwiseClone` method, thereby avoiding unintentional modification of the original object. This solution is suitable for simple classes; for more complex scenarios consider implementing a custom deep copy mechanism.