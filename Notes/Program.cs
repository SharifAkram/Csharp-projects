// var book = (title: "Lost in the Snow", author: "Holly Webb");
// Console.WriteLine(book.title);

/*
using System;

class Program
{
    static void Main()
    {
        var book = new Tuple<string, string>("Lost in the Snow", "Holly Webb");
        Console.WriteLine(book.Item1);
    }
}

using System;

class Program
{
    private string message = "This is a custom message.";

    public string GetMessage()
    {
        return message;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Program programInstance = new Program();
        Console.WriteLine(programInstance.GetMessage());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!"); 
        Program programInstance = new Program();
        Console.WriteLine(programInstance);
    }
}

*/

using System;

// Define a simple struct
public struct MyStruct
{
    public int Number;
}

// Define a simple class
public class MyClass
{
    public string Name;

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the struct
        MyStruct myStructInstance;
        myStructInstance.Number = 17;

        // Create an instance of the class
        MyClass myClassInstance = new MyClass();
        myClassInstance.Name = "Sharif";

        // Display struct data
        Console.WriteLine("Struct Number: " + myStructInstance.Number);

        // Display class data
        myClassInstance.Display();
    }
}

// CTRL + K, C
// SHIFT + HOME or END or PgUp or PgDn
// CTRL + L