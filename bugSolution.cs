using System;

public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        ExampleClass obj1 = new ExampleClass(10);
        // Create a deep copy using MemberwiseClone
        ExampleClass obj2 = (ExampleClass)((ICloneable)obj1).MemberwiseClone();

        obj2.MyProperty = 20;

        Console.WriteLine(obj1.MyProperty); // Output: 10
        Console.WriteLine(obj2.MyProperty); // Output: 20
    }
} 