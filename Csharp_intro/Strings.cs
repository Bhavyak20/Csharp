using System;
class Strings
{
    static void Main()
    {
        Console.WriteLine("*** Concept is strings ***");
        string firstname = "Bhavya";
        string lastname = "sri";
        string fullname = firstname + lastname;
        //string fullname = ($"My first name is {firstname} and last name is {lastname}");
        Console.WriteLine(fullname);

        string firstcompany = "\"DXC \"";
        Console.WriteLine("I worked in " + firstcompany);

        //to assign a path from our sytem

        string coursepath = "C\\Users\\Kolli\\Desktop\\ConsoleApplication\\Csharp";
        Console.WriteLine($"My course path is {coursepath}");

        //to print everything in new line we use \n

        string numbers = " \n One\n TWO \n Three";
        Console.WriteLine("Numbers we are using here is " + numbers);

        //using string as questionble
        Console.WriteLine("what is your name ?");
        string name = Console.ReadLine();

        Console.WriteLine("What is your surname ?");
        string surname = Console.ReadLine();

        string realname = name + surname;
        Console.WriteLine("My full name is " + realname);

        //interpolation type

        Console.WriteLine($"My firstname is {firstname} and last name is {lastname}. So my full name is {fullname}");

        Main1();

    }

    static void Main1()
    {
        //to get length for string
        string data = "HELLO world is basic program";
        int datalength = data.Length;
        Console.WriteLine(datalength);
        Console.WriteLine(data);

        //to convert string data to lowercase
        string datalower = data.ToLower();
        Console.WriteLine("I conerted data string to lowercase " + datalower);

        //to convert string data to uppercase
        string dataupper = data.ToUpper();
        Console.WriteLine(dataupper);

        //to trim string
        string data1 = "      Beautifull      ";
        string data1_trimmed = data1.Trim();
        Console.WriteLine(data1_trimmed);

        string data2 = "*****Beatifull*****";
        string data2_starttrimmed = data2.TrimStart('*');
        Console.WriteLine(data2_starttrimmed);


        //string data2_endtrimmed = data2_starttrimmed.TrimEnd('*');
        string data2_endtrimmed = data2.TrimEnd('*');
        Console.WriteLine(data2_endtrimmed);


        //Console.WriteLine(data3);

        /*
         * padding concept
         * */
        string data3 = "Rainbow";

        string data3_padleft = data3.PadLeft(20);
        Console.WriteLine(data3_padleft);
        int length = data3_padleft.Length;
        Console.WriteLine(length);

        string data3_padright = data3.PadRight(30);
        Console.WriteLine(data3_padright);
        int data3right_length = data3_padright.Length;
        Console.WriteLine(data3right_length);

        //string comparision
        string password = "World@123";
        bool checkpassword = password.Equals("World@123"); //op:True
        /* bool checkpassword = password.Equals("World");//op false */
        Console.WriteLine(checkpassword);

        //substring

        string sentence = "The quick brown fox jumps over the lazy dog.";
        string substring = sentence.Substring(4, 11);
        Console.WriteLine(substring);

        string sentence1 = "My name is Bhavya Keerthi sri.";
        string sub = sentence1.Substring(11, 14);
        Console.WriteLine(sub);

        //replace word in string

        string data4 = "Space has so many stars.";
        string data4_replace = data4.Replace("stars", "Asteroids");
        Console.WriteLine(data4_replace);


        //Format : a format string is a string that directs how other strings, numbers, or decimals are displayed
        /* interpolation */

        int quantity = 5;
        double price = 9.99;

        string receipt = string.Format("You purcahsed {0} items for {1}", quantity, quantity * price);
        Console.WriteLine(receipt);

        int first = 10;
        byte second = 33;
        string trail = string.Format("My first number is {0} and second number is {1}", first, second * second);
        Console.WriteLine(trail);

    }


}

