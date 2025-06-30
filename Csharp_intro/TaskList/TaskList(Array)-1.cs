using System;

/// <summary>
/// Employees Data : 
//1.  “John, Robert, Chandra, Peter”
//2. [“John”, “Robert”, “Chandra”, Peter”]
/// </summary>
class TaskList_1
{
    static void Main()
    {
        /*
         * //Prepare the String Array 
         * */
        
        string[] EMPdata = { "John", "Robert", "Chandra", "Peter" };//First type of writing string array
       
        string[] empdet = new string[4];//second type of writing string array
        empdet[0] = "John";
        empdet[1] = "Robert";
        empdet[2] = "Chandra";
        empdet[3] = "Peter";

        /*
         * Get the Third Employee from the Array
         */
        Console.WriteLine("********************************");
        Console.WriteLine("Third Employee from Array is: " + EMPdata[2]);

        /*
         * Check whether Second and Third employee Equals or not from the Array
         */
        Console.WriteLine("********************************");
        bool Check =EMPdata[1] == EMPdata[2];
        Console.WriteLine($"Is Second and Third Employee is equal: {Check}");

        /*
         * Check the employee whose name starts with “J” from the Array
         */
        Console.WriteLine("********************************");
        foreach (string emp in EMPdata)
        {
            if (emp.StartsWith("J"))
            {
                Console.WriteLine($"Employe name start with 'J' is: {emp} ");
            }
        }
        /*
         * Convert Employees List into single String
         */
        Console.WriteLine("********************************");
        string convert=string.Join(" ",EMPdata);
        Console.WriteLine("Converted List of employee to string: " +convert);

        /*
         * Replace the “Robert” with “Peter” in String
         */
        Console.WriteLine("********************************");
        string replace= convert.Replace("Robert", "Peter");
        Console.WriteLine("After replacing rober with peter string look like: " +replace);

        /*
         * Get the Employee whose name length is more that 4 charcters from the array
         */
        Console.WriteLine("********************************");
        foreach (string employe in EMPdata)
        {
            if(employe.Length > 4)
            {
                Console.WriteLine("Print Employee whose name length is more that 4 charcters: " + employe);
            }
        }

        /*
         * Diff b/w for and foreach ? Explain with example
         */
        //Main difference between for and foreach is syntax and index.
        //in for loop we need to use index to print data but in foreach no need index to print.
        //foreach is simpler and easy to read data comparing to for
        //in for loop we can modify data

        Console.WriteLine("********************************");
        foreach (string empl in EMPdata)
        {
            Console.WriteLine($"List of Employee using foreach loop is : {empl}");
        }

        for (int em = 0; em < EMPdata.Length; em++)
        {
            //Console.WriteLine($"List of employee is using for loop : {EMPdata[em]}");

            //EMPdata[em] = EMPdata[em] + ".K";
            //EMPdata[em] = EMPdata[em].ToUpper();
            Console.WriteLine("List of employee after modifying with intial in for loop: " +EMPdata[em]);  
        }

        /*
         * Explain me what is the importance of the Looping system. ? Explain with Example
         * looping system used to allow set of stamenets to be executed until a certain condition is met.
         * below is example used while loop.
         */
        Console.WriteLine("********************************");
        for (int em = 0; em < EMPdata.Length; em++)
        {
            if (EMPdata[em] != "Chandra")
            {
                Console.WriteLine("Here i have given condition as not equal to chnadra," +
                    " so to meet this condition it will print " +
                    "employee names other than chnadra in array: " + EMPdata[em]);
            }
        }

        
        
    }

}

