using System;
/// <summary>
/// Looping system refers to the mechanisim that allows a set of statements to be executed repeatedly
/// until a certain conditions is met
/// </summary>
class LoopingSystem
    {
    static void Main()
    {
        //while loop

        ////example using while loop for int
        int money = 0;
        Console.WriteLine($"My money before loop {money}");
        while (money < 3)
        {
            money = money + 1;
            Console.WriteLine($"My money after loop: {money}");
        }

       //example of while loop using if condition for int array
        int[] currency = { 50, 100, 150, 100, 250, 300 };
        int test = 0;
        int total_currency = 0;
        //while (test <6)
        //{
        //    Console.WriteLine($"List of Indian currency before addingis {currency[test]}");
        //    total_currency = total_currency + currency[test];
        //    Console.WriteLine($"List of ammount after adding is {total_currency}");
        //    test = test + 1;
        //}
        while(test < 6)
        {
           Console.WriteLine("List of currencies available:" + currency[test]);
            if (currency[test] == 100)
            {
                Console.WriteLine($"List of 100 Indian ruppees  {currency[test]}");
                total_currency = total_currency + currency[test];
                Console.WriteLine($"List of ammount after adding is {total_currency}");
            }
            test = test + 1;
        }
        Dowhile();
        Foreach();
        For();
    }

    static void Dowhile() 
    {
        //do while is same like while loop but executes at least once as the condition is trues


        Console.WriteLine("**************DO WHile loop*********");
        int count = 0;
        do
        {
            Console.WriteLine("this is example of do while loop");
            count = count + 1;
        } while (count < 3);

        //example-2

        int[] money = { 10, 50, 100, 200 };
        int money_test = 0;
        int total_money = 0;
        do
        {
            Console.WriteLine("List of money:" + money[money_test]);
            total_money = total_money + money[money_test];
            Console.WriteLine("Total amoubt of money available is: " + total_money);

            money_test++;
        } while (money_test < 4);

        //example applying if condition
        int[] age = { 3, 10, 35, 38 };
        int age_test = 0;
        do
        {
            if (age[age_test] == 35)
            {
                Console.WriteLine("Age of mother is: " + age[age_test]);
            }
            age_test = age_test + 1;
        } while (age_test < 4);

    }

    static void Foreach()
    {
        //foreach Iterates through each element in a collection(eg:array,list)
        string[] family_names = { "Daughter,Son,Mother,Father" };
        foreach(string fam in family_names  ){
            Console.WriteLine($"In a family there are: {fam}");
        }
        int[] random_numbers = { 9, 99, 999 };
        
        foreach (int random in random_numbers)
        {
            Console.WriteLine("list of random numbers is: " + random);
            if (random == 99)
            {
                Console.WriteLine("double digit number is: " + random);
            }
            //Console.WriteLine("list of random numbers is: " + random);
        }
    }

    static void For()
    {
        int[] employee_id = { 876, 432, 123 };
        for (int employee = 0; employee < employee_id.Length; employee = employee + 1)
        {
            Console.WriteLine($"List of Employee Id's are:" + employee_id[employee]);
        }

        int[] versions = { 164, 165, 162 };
       
        for(int ver = 0; ver < versions.Length; ver = ver + 1)
        {
            Console.WriteLine("There are three versions available to our application:" + versions[ver]);
            if (versions[ver] == 165)
            {
                Console.WriteLine("this is the latest version availabel:" + versions[ver]);
            }
            
        }
    }
}


