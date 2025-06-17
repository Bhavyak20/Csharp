using System;
 class Strings
    {
    static void Main()
    {
        Console.WriteLine("*** Concept is strings ***");
        string firstname = "Bhavya";
        string lastname = "sri";
        string fullname = firstname + lastname;
        //string fullname = ($"My first name is {firstname} and last name is {lastname}");
        Console.WriteLine(fullname);

        string firstcompany = "\"DXC \"";
        Console.WriteLine("I worked in " + firstcompany);

        //to assign a path from our sytem

        string coursepath = "C\\Users\\Kolli\\Desktop\\ConsoleApplication\\Csharp";
        Console.WriteLine($"My course path is {coursepath}");

        //to print everything in new line we use \n

        string numbers = " \n One\n TWO \n Three";
        Console.WriteLine("Numbers we are using here is " + numbers);

        //using string as questionble
        Console.WriteLine("what is your name ?" );
        string name = Console.ReadLine();

        Console.WriteLine("What is your surname ?");
        string surname = Console.ReadLine();

        string realname = name + surname;
        Console.WriteLine("My full name is " + realname);

        //interpolation type

        Console.WriteLine($"My firstname is {firstname} and last name is {lastname}. So my full name is {fullname}");
       

    }
    }

