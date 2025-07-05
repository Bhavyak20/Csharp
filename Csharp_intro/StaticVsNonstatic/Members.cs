using System;
namespace StaticNonstaticMembers
{
    public static class MembersStatic
    {
        public static string EmployeName="Bhavya";
        public static int EmployeID = 789;
        public static void EmployeNameDetails()
        {
            Console.WriteLine(EmployeName);
        }
        public static int  EmployeIDDetails()
        {
            return EmployeID;
        }
    }
    public class MembersNonstatic
    {

        public static string companyName = "TCS";
        public int CompanyCode = 123;
        public int CompanyCodeDetails()
        {
            return CompanyCode;
        }
        public void CompanyNameDetails()
        {
            Console.WriteLine(companyName);
        }
    }

    public class MainProgram
    {
        public static void Main()
        {
            //Here I have printed all static members in non static Main() method.
            Console.WriteLine($"name of the employee is {MembersStatic.EmployeName}");
            MembersStatic.EmployeNameDetails();
            MembersStatic.EmployeIDDetails();

            //Here I have printed all nonstatic members in non static Main() method by using Instance refernce.
            MembersNonstatic nonstatic = new MembersNonstatic();
            nonstatic.CompanyCodeDetails();
            Console.WriteLine($"{MembersNonstatic.companyName} company code is {nonstatic.CompanyCode}"); 
        }
    }
}

