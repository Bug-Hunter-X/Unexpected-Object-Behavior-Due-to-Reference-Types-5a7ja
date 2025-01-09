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
        ExampleClass obj2 = obj1; 

        obj2.MyProperty = 20; 

        Console.WriteLine(obj1.MyProperty); // Output: 20
        Console.WriteLine(obj2.MyProperty); // Output: 20
    }
}