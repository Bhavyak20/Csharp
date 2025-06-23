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
    }
    static void Elseif()
    {
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
}

