using System;
using System.CodeDom;
class Datatypes
    {
    static void Main()
    {
        //I'm using datatypes in this class 
        //1.Numeric data types in numeric DT there are two main types non-floating and floating
        //under nonfloating 1.byte 2.short 3.ushort 4.int 5.unit 6.long 7.ulong

        Console.WriteLine("****Now I'm writing byte data types****");
        //range of byte is 0 to 255 it won't take value more than 255
        byte age = 2;
        byte grade = 4;
        Console.WriteLine("My age is " +age);
        Console.WriteLine("I'm studying " +grade);

        Console.WriteLine("***Now example for short***");
        //Range for short is -32768 to 32767;
        short temparature = -20;
        Console.WriteLine("Today's temparature is " + temparature);

        //short value1 = -33333 //-- > op:it will show error;
        //Console.WriteLine(value1);

        Console.WriteLine("*** writing ushort example ***");
        //Range of ushort is 0 to 65,535
        ushort population = 60000;
        Console.WriteLine("Population in Vijayawada is " + population);

        Console.WriteLine("*** writing example for int ***");
        //Range of int is -2,147,483,648 to 2,147,483,648

        int world = 2045670120;
        Console.WriteLine("Total world population is " +world);

        Console.WriteLine("*** writing example for unit ***");
        //unit range is 0 to 4,294,967,295

        uint stars = 4000520199;
        Console.WriteLine("Maximum stars in galaxy will be more than " + stars);

        /*
        * long
            Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            Purpose: Used for very large or small integers
        */
        long worldPopulation = 7800000000L;
        Console.WriteLine("Long Value:" + worldPopulation);
        long point = -9;
        Console.WriteLine(point);

        /*ulong
            Range: 0 to 18,446,744,073,709,551,615
            Purpose: Large positive integers
        */

        ulong bankBalance = 100000000000000UL;
        Console.WriteLine("Ulong Value:" + bankBalance);


        /*
              Floating - Point Types(Fractional Values Allowed)
              decimal : ±79,228,162,514,264,337,593,543,950,335
              float   : ±3.40282347E+38F
              double  : ±1.7976931348623157E+308
       */
        decimal price = 199.99m;
        Console.WriteLine("Price Value:" + price);

        float pi = 3.1415199999f;
        Console.WriteLine("Pi Value:" + pi);

        double stockPrice = 987.65d;
        Console.WriteLine("stockPrice Value:" + stockPrice);

    }
}

