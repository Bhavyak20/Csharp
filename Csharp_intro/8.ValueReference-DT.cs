using System;
 class ValueReference_DT
    {
    /*
     * Data Types and catogeries
     //we have two types of Data types 1.Value data type  2.Reference Data Type.
     * */

    static void Main()
    {
        int number = 9;
        Console.WriteLine(number);//this is value type.
        //data is directly stored in number

        int value = number;
        Console.WriteLine(value);//this is reference type where number data is stored in value.
        //Value is address of actual data (number)


        /*
         * Boxing :Converting value type to reference type
         */

        int number1 = 100;//value type
        object test1 = number1;
        Console.WriteLine("Printing test1(reference type): " +test1);

        /*
         * Unboxing:Converting reference type back to value type
         */

        int number2=(int)test1;
        Console.WriteLine(number2);

        //tryimg boxing and unboxing for string type

        string word1 = "Beautiful";
        object test_word1 = word1;
        Console.WriteLine("Printing reference type using boxing method: " +test_word1);

        string word2=(string)test_word1;
        Console.WriteLine("Unboxed test_word1:" +word2);
    }
    }

