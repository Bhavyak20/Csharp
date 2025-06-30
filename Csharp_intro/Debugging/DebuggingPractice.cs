using System;
class DebuggingPractice
{
    static void Main()
    {
        string NameofStudent1 = Student1Name();
        //Console.WriteLine(NameofStudent1);

        string NameofStudent2 = Student2Name();
        int AgeofAdhvik = Student1Age(10);
        // Console.WriteLine($"Age of {NameofStudent1} is {AgeofAdhvik}");
        int AgeofAditya = Student2Age(4);

        string StudentDetails = Moredetails("Aditya");
        Console.WriteLine(StudentDetails);
    }

    static string Student1Name()
    {
        string student1 = "Adhvik";
        //string student2 = "Aditya";
        return student1;
    }
    static string Student2Name()
    {
        string student2 = "Aditya";
        return student2;
    }

    static int Student1Age(int age1)
    {
        return age1;
    }

    static int Student2Age(int age2)
    {
        return age2;
    }

    static string Moredetails(string studentname)
    {
        string school = "GreeanDale";
        int AgeofAdhvik = Student1Age(10);
        int AgeofAditya = Student2Age(4);
        if (studentname == "Aditya")
        {
            Console.WriteLine($"{studentname} is studying U.K.G.in {school} and his age is {AgeofAditya}");
        }
        else if (studentname == "Adhvik")
        {
            Console.WriteLine($"{studentname} is studying 4th Grade in {school} and his age is {AgeofAdhvik}.");
        }
        else
        {
            Console.WriteLine("No student details");
        }
        return school;
    }
}

