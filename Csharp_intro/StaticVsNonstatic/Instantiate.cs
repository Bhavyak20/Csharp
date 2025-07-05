
using System;

using System.Security.Cryptography.X509Certificates;

namespace StaticAndNonstatic
{
    /// <summary>
    /// In this program I have created Static class, non static classes and 
    /// called those two classes in Static class Main()Method.
    /// Here we can see variation between how we call static and non static classes.
    /// </summary>
    public static class StaticProgram
    {
         public static string Myname = "Bhvaya";
        public static void MainMessage()
        {
            Console.WriteLine("This is Static method in static class");

        }

    }
    public class ProgramNonstatic
    {
       public string company = "TCS";
       public void MainMessage()
        {
            Console.WriteLine("This is Nonstatic method in nonsttaic class");
        }
    }

    public class  ProgramNonstatic1
    {
        public int MyId = 123;
        public void MainMesage(string Location)
        {
           ProgramNonstatic programNonstatic= new ProgramNonstatic();
            Console.WriteLine($"I'm working in {programNonstatic.company} and Location is {Location}");
        }
    }

    /// <summary>
    /// We can define Main() method in non static class.But Main()method should be static..
    /// class that contains it dosen't have to be static.
    /// </summary>
    public static class StaticMainProgram //public class StaticMainProgram 
    {
        static void Main()
        {
            StaticProgram.MainMessage();
            //here I have called MainMessage(static method) from StaticProgram(static class) only because of public key word.
            ProgramNonstatic nonstat = new ProgramNonstatic();
            nonstat.MainMessage();

            //Here I have called Mainmessage(NON-static method) from ProgramNonstatic1(non static class),only with instance reference.
            //so for calling static non need of instance but for non static we need instance.

            ProgramNonstatic1 nonstat1 = new ProgramNonstatic1();
            nonstat1.MainMesage("Banglore");
        }
    }
}