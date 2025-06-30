using System;
 class TaskList_2
    {
    static void Main()
    {
        string[] EMPdata = { "John", "Robert", "Chandra", "Peter" };//First type of writing string array
        /*
         * What are the floating data types ? EXample
         * Floting data types is point type it will allow fraction values to assign
         * types:1.decimal (Used for calculation off money transaction it has to be end with "m"
         * 2.float  (must mention with "f")
         * 3.double(must mention with d and used for mathematical computation)
         */
        Console.WriteLine("********************************");
        Console.WriteLine($"float datatype MaxValue: {float.MaxValue} and MinValue: {float.MinValue}");
        Console.WriteLine($"decimal datatype MaxValue: {decimal.MaxValue} and MinValue: {decimal.MinValue}");
        Console.WriteLine($"double datatype MaxValue: {double.MaxValue} and MinValue: {double.MinValue}"); // double has a greater range than int

        float number1 = 98.6f;
        Console.WriteLine("Writing value of float data types:" + number1);
        Console.WriteLine("Data types of number1 is" + number1.GetType());

        decimal number2 = 1000.65m;
        Console.WriteLine("Data types of number2" + number2.GetType());

        double number3 = 999999.9d;
        Console.WriteLine("Data types of number3 is: " + number3.GetType());

        /*
         * What are the Logical operators importance of that ? Explain with example
         //&&(and) both values must be true,||(OR) at least one should be true,!(NOT)Reverses the result
         */
        Console.WriteLine("********************************");
        //AND(&&)
        bool test1 = (EMPdata.Length == 10) && (EMPdata.Length < 10);//here op will false because first value is not true
        Console.WriteLine(test1);
        bool test2 = (EMPdata.Length == 4) && (EMPdata.Length < 6);//op:true(both values are true)
        Console.WriteLine(test2);

        //||(OR)
        bool test3 = (EMPdata.Length == 10) || (number1 < 100f);//op:true(second value is true
        Console.WriteLine(test3);
        bool test4 = (number2 > 2000) || (number1 < 0);//false(both values are not correct.
        Console.WriteLine(test4);

        //!
        bool test5 = !(EMPdata.Length == 4);//here value is true but we given "!" before value so it will reverse the output
        Console.WriteLine(test5);
        bool test6 = !(number1.GetType() == number2.GetType());
        Console.WriteLine(test6);////here value is false(both data types are different) but we given "!" before value so it will reverse the output

        /*
         * What is the nullable types ? Example
         nullable types allow value types (like int, bool, DateTime, etc.) to also hold a null value
         */
        Console.WriteLine("********************************");
        int? id = null;
        int employeID = id ?? 1234; // if marks is null, use 50
        Console.WriteLine(employeID);

        bool? value = null;
        bool valueiszero = value ?? true;
        Console.WriteLine(valueiszero);

        /*
         * What is implicit conversation type ? Example
        //It is like type promotion
        It occurs when you convert smaller DT without loosing data.
         */
        Console.WriteLine("********************************");
        byte data1 = 100;
        Console.WriteLine(data1.GetType());
        int convert1=(int)data1;
        Console.WriteLine(convert1.GetType());

        short data2 = 19000;
        Console.WriteLine(data2.GetType());
        ushort convert2=(ushort)data2;
        Console.WriteLine(convert2.GetType());

        char intial = 'K';
        string convert3 = intial.ToString();
        Console.WriteLine(convert3.GetType());

        ushort data3 = 55400;
        Console.WriteLine(data3.GetType());
        int convert4=(int)data3;
        Console.WriteLine(convert4.GetType());

        short data4 = 29000;
        ushort convert5=(ushort)data4;
        Console.WriteLine(convert5.GetType());
    }
}
