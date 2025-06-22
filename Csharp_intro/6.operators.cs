using System;
 class operators
    {
    static void Main()
    {
        // Arithmetic Operators
        // + : Adds two operands. Example: 5 + 3 results in 8.
        // - : Subtracts the second operand from the first. Example: 10 - 4 results in 6.
        // * : Multiplies two operands. Example: 3 * 4 results in 12.
        // / : Divides the first operand by the second. Example: 10.0 / 3.0 results in approximately 3.3333.
        // % : Returns the remainder of a division operation. Example: 10 % 3 results in 1.

        // Comparison Operators it return the boolean
        // == : Checks if two operands are equal. Example: 5 == 5 results in true.
        // != : Checks if two operands are not equal. Example: 5 != 3 results in true.
        // > : Checks if the first operand is greater than the second. Example: 8 > 5 results in true.
        // < : Checks if the first operand is less than the second. Example: 3 < 7 results in true.
        // >= : Checks if the first operand is greater than or equal to the second. Example: 8 >= 8 results in true.
        // <= : Checks if the first operand is less than or equal to the second. Example: 3 <= 7 results in true.

        // Logical Operators
        // && : Returns true if both operands are true. Example: true && true results in true.
        // || : Returns true if at least one of the operands is true. Example: true || false results in true.
        // ! : Inverts the boolean value. Example: !true results in false.


        byte sum = (5 + 3);
        int differnce = (10 - 4);
        int productsLength = (3 * 4) + 5;   //17
        double result = (10.9 / 3.7);
        double remainder = (10 % 3);
        //string test = $"{sum}"
        string ouput = string.Format("Sum is {0} difference {1} productsLength {2} result {3} remainder {4}",
             sum, differnce, productsLength, result, remainder);
         Console.WriteLine(ouput);

        //Arithematic operators
        byte addition = (10 + 200);         //nonfloting
        short subtraction = (30000 - 10000);//nonfloting
        ushort multiplication = (2 * 5000); //nonfloting
        double division_remainder = (300 % 10); //floating
        double division = (50.1 / 10);
        string test= string.Format(" value of addition is {0},value of subtraction is {1},value of multiplication is {2},value of remainder is {3},value of division {4}",
                            addition, subtraction, multiplication, division_remainder,division);
        Console.WriteLine(test);

        /*//Comparision operators
        //it will have bool datatypes true or false result
        //Console.WriteLine("****Compare operators are useful for Compare the values****");
        */
        bool equal = (5 == 5); //op:True
        bool notequal = (9 != 3); //op:true
        Console.WriteLine($"{equal} and {notequal}");
        bool lessthan = (9 < 99);//op:true
        bool greaterthan = (9 > 99); //op:false
        Console.WriteLine($"{lessthan} and {greaterthan}");
        bool less_or_equal = (99 <= 9); //op:false
        bool greater_or_equal = (99 >= 10);//op:true
        Console.WriteLine($"{less_or_equal} and {greater_or_equal}");

        //more example
        string userName = "John";
        int lenthOfUserName = 4;

        bool isUserNameLengthCorrect = (userName.Length == lenthOfUserName);
        Console.WriteLine(isUserNameLengthCorrect);

        //
        int value = 9;
        double dvision = (27 / 3);

        bool value_dvision=(value == dvision);
        Console.WriteLine("Comaparision of value and division is " +value_dvision);//op:True

        //

        string myname = "keeerrrrrrrrr";
        
        bool myname_value = (myname.Length <= value);//op:false
        Console.WriteLine("compaarision of myname_value is " + myname_value);


        //string in array form
        string[] currencyItems = { "10$", "20$", "30$" };
        //string[] currencyItems = new string[] { "10$", "20$", "30$" };
        int noOfCurrencyItems = 3;
        Console.WriteLine("price of a choclate is:" + currencyItems[0]);
        
        ////string[3] currecnyItems = []

        bool isCurrnceyNotesEqaual = (currencyItems.Length == noOfCurrencyItems);
        Console.WriteLine(isCurrnceyNotesEqaual);


        // Logical Operators  && ||  !

        Console.WriteLine("***************** && (And) operator****************");
        //bool checkResult1 = true && true;         //true
        //Console.WriteLine(checkResult1);

        //bool checkResult2 = (5 == 5) && (5 != 3); //true
        //Console.WriteLine(checkResult2);
        ////                      T           F
        //bool checkResult3 = (5 == 5) && (5 == 3); //false
        //Console.WriteLine(checkResult3);

        //bool checkResult4 = (5 == 3) && (5 == 5); //false
        //Console.WriteLine(checkResult4);

        //bool checkResult5 = (5 == 3) && (5 == 3); //false
        //Console.WriteLine(checkResult5);


        Console.WriteLine("***************** && (Or) operator****************");
        bool checkResult1 = true || true;         //true
        Console.WriteLine(checkResult1);

        bool checkResult6 = false || false;       //false
        Console.WriteLine(checkResult6);

        bool checkResult2 = (5 == 5) || (5 != 3); //true
        Console.WriteLine(checkResult2);
        //                      T           F
        bool checkResult3 = (5 == 5) || (5 == 3); //true
        Console.WriteLine(checkResult3);

        bool checkResult4 = (5 == 3) || (5 == 5); //true
        Console.WriteLine(checkResult4);

        bool checkResult5 = (5 == 3) || (5 == 3); //false
        Console.WriteLine(checkResult5);


        bool oppTrue = !true;  //false
        Console.WriteLine(oppTrue);

        bool oppFalse = !false; //true
        Console.WriteLine(oppFalse);



        //null -> No value   1, 23


        //int age = 30;  //Value type

        //int? age = null;

        //int id 

        int age = 30;

        Console.WriteLine("Age is " +age);

        bool? nullbaleBool = null;
        Console.WriteLine("nullbaleBool is ", nullbaleBool);

        bool? nullbaleBool1 = false;


    



}
}

