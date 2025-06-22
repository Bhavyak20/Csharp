using System;
using System.Net.NetworkInformation;

internal class VarAndDynamic
    {
    static void Main()
    {
        Console.WriteLine("*** Now I'm writing examples for Var and dynamic ***");
        //var keyword examples
        //for var keyword we can assign differnt value but it has to be same datatype which we mentioned at intial
        var v_myname = "Bhavya";
        v_myname = "Divya";
        v_myname = "Kavya";
        Console.WriteLine("My name is " + v_myname);
        Console.WriteLine("Data type of v_myname is " + v_myname.GetType());

        var v_number = 12345;
        v_number = 6789;
        v_number = 7654;
        Console.WriteLine("My number is " +v_number);
        Console.WriteLine($"Data type of v_number is {v_number.GetType()}");

        var v_temparature = 3.2f;
        v_temparature = 2.6f;
        Console.WriteLine("Today temparature is " + v_temparature);
        Console.WriteLine("Data TYpe of V_temparature is " + v_temparature.GetType());

        dynamic();
    }

    static void dynamic() {
        Console.WriteLine("*** DYNAMIC Key word example ***");
        //dynamic keyword examples
        //for dynamic keyword we can assign differnt value and can alos different datatype 
        dynamic d_number = 9;
        d_number = "sree";
        Console.WriteLine("Number given in in dynamic method is " + d_number);
        Console.WriteLine("Data type of d_number is " + d_number.GetType());

        dynamic d_price = 600000123;
        d_price = 99.6m;
        d_price = -65.9;
        d_price = "hundred dollars";
        Console.WriteLine("Price value is " + d_price);
        Console.WriteLine("Data type of d_price is " + d_price.GetType());
    }
    }

