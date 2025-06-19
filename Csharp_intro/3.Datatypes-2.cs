using System;
using System.Security.Cryptography;
class Datatypes_2
    {
    static void Main()
    {
        //Display the max and min values of numeric datatypes

        Console.WriteLine("byte Max Value " + byte.MaxValue);
        Console.WriteLine("byte Min Value " + byte.MinValue);
        Console.WriteLine("short maximum value " + short.MaxValue);



        //${________________________________________________}
        //String interpolation
        // Display the maximum and minimum values using string interpolation
        Console.WriteLine($"byte datatype MaxValue: {byte.MaxValue} and MinValue: {byte.MinValue}");
        Console.WriteLine($"short minimum value : {byte.MinValue} and maximum value is: {short.MaxValue}");
        Console.WriteLine($"short datatype MaxValue: {short.MaxValue} and MinValue: {short.MinValue}");
        Console.WriteLine($"ushort datatype MaxValue: {ushort.MaxValue} and MinValue: {ushort.MinValue}");
        Console.WriteLine($"uint datatype MaxValue: {uint.MaxValue} and MinValue: {uint.MinValue}");
        Console.WriteLine($"ulong datatype MaxValue: {ulong.MaxValue} and MinValue: {ulong.MinValue}");
        Console.WriteLine($"float datatype MaxValue: {float.MaxValue} and MinValue: {float.MinValue}"); // 3.402823E+38 means 3.402823*10^38 (10 to the power of 38)
        Console.WriteLine($"decimal datatype MaxValue: {decimal.MaxValue} and MinValue: {decimal.MinValue}");
        Console.WriteLine($"double datatype MaxValue: {double.MaxValue} and MinValue: {double.MinValue}"); // double has a greater range than int
        Console.WriteLine($"int datatype MaxValue: {int.MaxValue} and MinValue: {int.MinValue}");
        Console.WriteLine($"long datatype MaxValue: {long.MaxValue} and MinValue: {long.MinValue}");


        Console.WriteLine($"decimal datatype MaxValue: {decimal.MaxValue} and MinValue: {decimal.MinValue}");
        Console.WriteLine($"flaot datatype MaxValue: {float.MaxValue} and MinValue: {float.MinValue}");
        Console.WriteLine($"double datatype MaxValue: {double.MaxValue} and MinValue: {double.MinValue}");

        Main2();

    }
    static void Main2() {
        //bool data type
        bool sevenwonders = true;
        bool sixwonders = false;
        Console.WriteLine("we have total seven wonders " + sevenwonders);
        Console.WriteLine("we have total six wonders " + sixwonders);

        //char data type

        char initial = 'K';
        Console.WriteLine($"My surname is {initial} ");

        //string data type

        string myname = "Bhavya sri" ;
        Console.WriteLine($"My name is {myname}");
    }

}

