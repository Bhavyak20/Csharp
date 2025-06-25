using System;
/// <summary>
/// In this program we used *****Return type Methods(non void)******
/// key points:
/// 1.If we use string data types for method we have declare values in form of string only,
/// we can't use anyother dataatypes
/// </summary>
     class Methods_ReturnTypes
    {
    static void Main()
    {
        string student1_name = Method1();
        Console.WriteLine(student1_name);

        int student1_number = Method2();
        Console.WriteLine(student1_number);

        //string student2=Method3("Adhvik", 9);
        //Console.WriteLine(student2);
        //callmethod1();
        callmethod2();
    }
    static string Method1()
    {
        string student_name = "Aditya";
        //Console.WriteLine($"Name of the student is {student_name}");
        return $"Name of the student1 is {student_name}";
    }
    static int Method2()
    {
        int student1_number = 999;
        return student1_number;
    }
    static string Method3()
    {
        string name = "Adhvik";
        return$"Name of student2 is {name}.";
    }
    static int Method4()
    {
        int student2_number = 99;
        return student2_number;
    }
    static void callmethod1()
    {
        string student2_name = Method3();
        Console.WriteLine(student2_name);

        int student2 = Method4();
        Console.WriteLine(student2);
    }
    static void callmethod2()
    {
        callmethod1();
    }
}

    

