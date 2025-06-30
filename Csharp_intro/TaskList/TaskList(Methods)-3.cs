using System;
class TaskList_3
{

    static void Main()
    {
        string EMP1Details = Employee1("Raj", 1234, "Developer");
        Console.WriteLine(EMP1Details);

        int EMP2Details = Employee2(5678, "Harsh", 7, 1);
        Console.WriteLine(EMP2Details);

        EmployeeDetails();
        Switchcase();
        Conditional();
    }
    /*
    * Prepare the Method with params with return types.
    */

    static string Employee1(string emp1Name, int emp1ID, string emp1Role)
    {
        string Company = "TCS";
        Console.WriteLine($"{emp1Name} works in {Company} his empID is {emp1ID} and role is {emp1Role}");
        return Company;

    }

    static int Employee2(int emp2ID, string emp2Name, int emp2Experience, int emp2Level)
    {
        int emp2Number = 987654321;
        Console.WriteLine($"{emp2Name} has total {emp2Experience} years experience and in {emp2Level} level.His employeID is {emp2ID}.");
        return emp2Number;



    }


    /*
     * Prepare the Methods with conditions (if, elseif, else)
     */
    static void EmployeeDetails()
    {

        string[] emp_names = { "John", "Chandra", "Peter" };
        int[] emp_experience = { 4, 3, 4 };
        string company_name = "CTS";
        int emp1_ID = 987;
        int emp2_ID = 654;
        int emp3_ID = 321;
        //if condition
        if (emp1_ID + emp2_ID >= 1000)
        {
            string Test1 = string.Format("Print name of Emp1name is {0} and ID is {1}", emp_names[0], emp1_ID);
            Console.WriteLine(Test1);
        }
        //else if condition
        if (emp_experience.Length != 3)
        {
            Console.WriteLine("Experinece of employee are mentioned in array");
        }

        else if (emp_experience.Length != emp_names.Length)
        {
            Console.WriteLine("Employe Id's of employees are mentioned in array.");
        }
        else if (company_name == "CTS")
        {
            string Test2 = string.Format("{0} , {1}, {2} works in {3}", emp_names[1], emp_names[1], emp_names[2], company_name);
            Console.WriteLine(Test2);
        }

        //else condtion
        if (emp_names.Length != 3)
        {
            Console.WriteLine("There are total 3 employee names given");
        }
        else if (emp1_ID == emp2_ID)
        {
            Console.WriteLine($"{emp_names[0]} employee ID is {emp1_ID}");
        }
        else if (emp2_ID > 1000)
        {
            Console.WriteLine($"{emp_names[1]} employee ID is {emp2_ID}");
        }
        else if (emp_names.Length <= 1)
        {
            Console.WriteLine($"{emp_names[2]} employee ID is {emp3_ID}");
        }
        else
        {
            Console.WriteLine("No employee details are available");
        }

    }

    /*
     * Prepare the methods with Conditions (switch case)
     */
    static void Switchcase()
    {
        int num = 2;
        int num1 = 8;
        int num2 = 34;
        int num3 = 100;

        switch (num)
        {
            case (1):
                Console.WriteLine("Printing num1" + num1);
                break;
            case (2):
                Console.WriteLine("Printing num2: " + num2);
                break;
            case (3):
                Console.WriteLine("Printing num3" + num3);
                break;
            default:
                Console.WriteLine("only 3 cases are mentioned");
                break;
        }
        int languages = 3;
        switch (languages)
        {
            case (1):
                Console.WriteLine("First Language is TELUGU");
                break;
            case (2):
                Console.WriteLine("Second Language is HINDI");
                break;
            case (3):
                Console.WriteLine("Third Language is ENGLISH");
                break;
            default:
                Console.WriteLine("We have only three Languages");
                break;
        }


    }

    /*
     *Prepare the Methods with if else if else and Switch case conditions.
     */

    static void Conditional()
    {
        string carowner = "Adhvik";
        string carname = "AUDI";
        string carcolour = "White";
        int carnumber = 1234;
        string carmodel="High End";

        //if statement

        if(carnumber== 1234)
        {
            Console.WriteLine($"Number of car is " + carnumber);
        }

        //else if statement

        if(carnumber != 1234)
        {
            Console.WriteLine($"Number of car is " + carnumber);
        }
        else if (carname =="AUDI")
        {
            Console.WriteLine($"{carowner} bought and {carname} this weekend");
        }

        //else statement

        if(carowner == "Aditya")
        {
            Console.WriteLine("Aditya Bought Benz in this month");
        }
        else if(carcolour == "Black")
        {
            Console.WriteLine($"BENZ car is bought by Aditya");

        }
        else
        {
            Console.WriteLine($"There is no details about {carname} car");
        }


        switch (carcolour)
        {
            case "Red":
                Console.WriteLine("name of the car is: " + carname);
                break;
            case "Black":
                Console.WriteLine("Owner of the car is " + carowner);
                break;
            case "White":
                Console.WriteLine($"{carowner} bought new {carname} which model is {carmodel}");
                break;
            default:
                Console.WriteLine("aditya bought BENZ ");
                break;

        }
    }
}


