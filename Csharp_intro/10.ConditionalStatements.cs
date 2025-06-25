using System;
/// <summary>
/// Now we are writing conditional statements they are 1.if 2. elseif 3.else 4.switchcase
/// </summary>
class ConditionalStatements
{
    static void Main()
    {
        int number = 9;
        int number1 = 100;
        string name = "bhavya";
        if (number == 9)
        {
            Console.WriteLine($"My lucky number is {number}");
        }
        if (number > 99)
        {
            Console.WriteLine("9 is not greater than 99.");
        }
        if (number <= number1)
        {
            Console.WriteLine("This statement is true because 9 is less than 100");
        }
        if (name == "havya")
        {
            Console.WriteLine("name is incorrect");
        }
        Elseif();
        Else();
        Switchcase();
        TernaryOprator();
    }
    static void Elseif()
    {
       //example-1
        bool value = true;
        bool statement = false;
        if (statement)
        {
            Console.WriteLine("statement value is false");
        }
        else if (value)
        {
            Console.WriteLine($"Value is true");
        }

        //example-2
        int oddnumber = 9;
        if(oddnumber == 9)
        {
            Console.WriteLine($"{oddnumber} is odd number");
        }
        else if(oddnumber == 9)
        {
            Console.WriteLine($"{oddnumber} is largest one digit odd number");
        }

            double number = 58.9d;
        int convert = (int)number;
        Console.WriteLine(convert);

        if (convert == number)
        {
            Console.WriteLine("Converted double value to int");
        }
        else if (convert < 58)
        {
            Console.WriteLine("value of convert is correct");
        }

        else if (number == 58.9d)
        {
            Console.WriteLine("Double value is correct");
        }
    }
    static void Else()
    {
        decimal price = 9000m;
        int purchased_price = 9000;
        if (price < purchased_price)
        {
            Console.WriteLine("The price and purchased is same");
        }
        else if (purchased_price > price)
        {
            Console.WriteLine($"value of{price} is equal to 9000");
        }
        else
        {
            Console.WriteLine("No statement to print");
        }

        //example-2
        int even_number = 22;
        if (even_number == 222) 
        {
            Console.WriteLine("22 is even number");
        }
        else if(even_number == 0)
        {
            Console.WriteLine("22 is double digit even number");
        }
        else
        {
            Console.WriteLine("no statements to prin about even numbert");
        }
    }
    static void Switchcase()
    {
        int num = 2;
        int num1 = 8;
        int num2 = 34;
        int num3 = 100;

        switch (num)
        {
            case (1):
                Console.WriteLine("Printing num1" + num1);
                break;
            case (2):
                Console.WriteLine("Printing num2: " + num2);
                break;
            case (3):
                Console.WriteLine("Printing num3" + num3);
                break;
            default:
                Console.WriteLine("only 3 cases are mentioned");
                break;
        }

        int case_num = 6;
        switch (case_num) 
        {
            case (1):
                Console.WriteLine("First subject is TELUGU");
                break;
                case (2):
                Console.WriteLine("second subject is ENGLISH");
                break;
                case (3):
                Console.WriteLine("Third subject is Maths");
                break;
                case (4):
                Console.WriteLine("Fourth subject is SCIENCE");
                break;
            case (5):
                Console.WriteLine("Fifth subject is SOCIAL");
                break;
            default:
                Console.WriteLine("There are only 5 subject");
                break;
        }
    }

    static void TernaryOprator()
    {
        //ternary operator is also used to check condition here imp key values are ? and :
        int num9 = 99;
        string result = num9 > 9 ? "99 is greater than 9" : "99 is Not less than 9";
        Console.WriteLine(result);


        string myname = "Aditya";
        string myname_result = myname == "Adtya" ? "Yes my name is Aditya" : "No my name is Adhvik";
        Console.WriteLine(myname_result);

    }


}

