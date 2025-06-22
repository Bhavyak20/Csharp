using System;
using System.Net.NetworkInformation;
class Array
{
    static void Main()
    {
        /*
         * Array:Collection of multiple values is called array.
         * we can have different type of values like 
         1.multiple values 2.empty values 3.null values
         */

        //taking array in string(one type of writing using array)
        int[] array1 = new int[3];
        array1[0] = 100;
        array1[1] = 200;
        array1[2] = 300;
        Console.WriteLine("Printing first value mentioned in array1:" + array1[0]);
        Console.WriteLine("Printing second value mentioned in array1:" + array1[1]);
        Console.WriteLine("Printing third value mentioned in array1:" + array1[2]);
        int test_array1 = array1[2] - array1[0];
        Console.WriteLine("Did subtraction using arithematic operation (-): " + test_array1);

        //(second type of writing using array)
        int[] array2 = { 400, 500, 600, 9, 99, 999 };
        Console.WriteLine($" Length of array2 is: {array2.Length}");
        Console.WriteLine("Values of array2 is {0},{1},{2},{3},{4},{5}",
            array2[0], array2[1], array2[2], array2[3], array2[4], array2[5]);
        Foreach1();
        Foreach2();
    }
    static void Foreach1()
    /*
     * For each is looping mechanisim used for collections
     * to print each adn every value in array we use for each loop mechanisim
     */
    {
        string[] fruitsbasket = { "apple,mango,orange" };
        foreach (string fruit in fruitsbasket)
        {
            Console.WriteLine("Fruits in basket are :" + fruit);
        }
        int[] marks = { 100, 250, 150, 200 };
        foreach (int subject in marks)
        {
            Console.WriteLine("We have different markes for subjects: " +subject);
        }

        foreach (int add in marks)
        {
            int addmarks = 50;
            int marksUpdated = add + addmarks;
            Console.WriteLine("Marks after updating is: " +marksUpdated);
        }
    }
    static void Foreach2()
    {
        int[] prices = { 2000, 1500, 999, 1999 };
        foreach (var cost in prices)
        {
            Console.WriteLine("Prices of purchase in INR is: " + cost);
        }

        foreach (var costAdd in prices)
        {
            int add = 1000;
            int updated_prices = costAdd + add;
            Console.WriteLine("Prices of purchase after adding 1k in INR is: " + updated_prices);
        }
    }
    
    
    }

