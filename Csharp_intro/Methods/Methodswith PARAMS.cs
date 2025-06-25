using System;
class Methodswith_PARAMS
{
    static void Main()
    {
        Method1("Devika");
        Method2(123);
        Method3("NRI", "HYD", 4);
    }
    static void Method1(string studentname)
    {
        Console.WriteLine(studentname);
    }

    static void Method2(int studnetID)
    {
        Console.WriteLine(studnetID);
    }
    static void Method3(string scoolname, string schoolLocation, byte schoolBranches)
    {
        Console.WriteLine($"{scoolname} school is located at {schoolLocation} and has total {schoolBranches} branches");
    }
}

