using System;
/// <summary>
/// There are two types of methods
/// 1.Void method-->we can't write return value or can't use retuen key word.
/// 2.Non void-->we can use return types in this non void method
/// In this program we see ***** VOID TYPE METHOD******
/// </summary>

 class Methods_1
    {
    static void Main() 
    {
        Method1();
        Method2("Adhvik", 9);

        callmethods();
    } 
    static void Method1()
    {
        Console.WriteLine("This is void method.In void we can't write return value");
    }
    static void Method2(string name,int age)
    {
        Console.WriteLine($"Student name is {name} and age is {age}");
    }

    static void Method3()
    {
        Console.WriteLine("Method3 is called here ");
    }
    static void Method4()
    {
        Console.WriteLine("Method4 is called here ");
    }
    static void callmethods()
    {
        Method4();
    }
    
 }

