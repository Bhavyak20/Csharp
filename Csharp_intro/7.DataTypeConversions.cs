using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

internal class DataTypeConversions
    {
    static void Main()
    {
        //converting byte to int

        byte num = 10;
        Console.WriteLine(num);
        int convert = (int)num;
        Console.WriteLine(convert);
        Console.WriteLine(convert.GetType());
        byte smallNumber = 5;
        int largeNumber = smallNumber;  //Implicitconversation from byto to Int
        Console.WriteLine(largeNumber);
        Console.WriteLine(largeNumber.GetType());
        Console.WriteLine(smallNumber.GetType());
        //converting double to int
        double num1 = 99.58;
        int convert1 = (int)num1;
        Console.WriteLine(convert1);
        
        double num2 = 58.6d;
        int convert2 = (int) num2;
        Console.WriteLine(convert2);
        //converting long to int
        long num3 = 60000;
        int convert3 = (int)num3;
        Console.WriteLine(convert3);
        //converting short to int
        short num4 = 30000;
        int convert4 = (int) num4;
        Console.WriteLine(convert4);
        ///converting int  to string
        int num5 = 42;
        string strNumber = num5.ToString();
        Console.WriteLine(strNumber);
        Console.WriteLine(strNumber.GetType());

        int num6 = 999;
        string convert6=num6.ToString();
        Console.WriteLine(num6.GetType());
        Console.WriteLine("Now this is string output:" +convert6);
        Console.WriteLine($" the data type of num6 after conversion to string is {convert6.GetType()}");

        //convert string to int

        string string1 = "60000";
       int string_convert1= int.Parse(string1);
        Console.WriteLine(string_convert1);
        Console.WriteLine(string_convert1.GetType());


        //value type numeric types    null to int   //ref
        string nullbaleString = null;
        //int output1 = int.Parse(nullbaleString);
        int output1 = Convert.ToInt32(nullbaleString);  //0
        Console.WriteLine(output1);

        string nullvalue = null;
        int nullconvert=Convert.ToInt32(nullvalue);
        Console.WriteLine("Trying to convert value type means null to integer " +nullconvert);


        DateTime dateTime = DateTime.Now;
        Console.WriteLine(dateTime.ToString());

       

    }
}

