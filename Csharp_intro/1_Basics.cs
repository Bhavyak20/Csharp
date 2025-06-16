using System;

     class FirstProgram
    {
        static void Main()
        {
        Console.WriteLine("My Method in Program Class");
        Console.WriteLine("My first code in C sharp");
        //Console.ReadLine();
        string value = Console.ReadLine();
        Console.WriteLine("My name is:" +value);

        
        displaymessage();
        Readmessages();
        }



    static void displaymessage()
    {
        Console.WriteLine("---->This is second method<----");

        Console.WriteLine("What is your first name ?");
        string firstname= Console.ReadLine();

        Console.WriteLine("What is your last name ?");
        string lastname= Console.ReadLine();

        string fullname = firstname + lastname;
        Console.WriteLine("Your full name is:" + fullname);
    }
    static void Readmessages()
    {
        Console.WriteLine("--->This is third method name is Read message<---");
    }
    }

