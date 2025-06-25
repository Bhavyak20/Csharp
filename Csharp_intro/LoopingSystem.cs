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

        //example using while loop for string array
        string[] student_names = {"Mahesh,NTR,Chaitanya,Ram"};
        int count = 0;
        while(count < student_names.Length)
        {
            Console.WriteLine($"List of students is {student_names[count]}");
            count = count + 1;
        }


        ////example using while loop for int
        //int money = 0;
        //Console.WriteLine($"My money before loop {money}");
        //while(money < 3)
        //{
        //    money=money +1 ;

        //    Console.WriteLine($"My money after loop: {money}");

        //}

        ////example using while loop for int array and adding total 

        //int[] age = { 18, 25, 48, 50 };
        //int fam_age = 0;
        //int total = 0;
        //while (fam_age < age.Length)
        //{
        //   Console.WriteLine($"Ages of members in family is {age[fam_age]} ");
        //    // fam_age = fam_age + 3;
        //    total = total + age[fam_age];
        //    //Console.WriteLine("Total count age count of family is:" +total);
        //    fam_age++;
        //}

        ////example using string in while loop

        //string[] sibling_names = {"Aditya,adhvik,abhi,abhay"};
        ////Console.WriteLine("Names of sibling is " + sibling_names[0]);
        //        int names = 0;
        //while(names < sibling_names.Length)
        //{
        //    Console.WriteLine($"Names of siblings in family is {sibling_names[names]}");
        //    names= names+1;
        //}

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
    }
    }

