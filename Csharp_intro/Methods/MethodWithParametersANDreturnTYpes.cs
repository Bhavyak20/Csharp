using System;
/// <summary>
/// /In this program we use ***** paramaetrs in methods with return types*****
/// </summary>
     class MethodWithParametersANDreturnTYpes
    {
    static void Main()
    {
      string company1_name=  Method1("DXC");//method1
        Console.WriteLine(company1_name);


        string Employes_Names=Method2("Naveen","Raja", "Kishore");//method2
        Console.WriteLine(Employes_Names);

        int Company_code=Method3();//method3
        Console.WriteLine(Company_code);

       int[] Employee_IDs=  Method4();//method4
        Console.WriteLine(Employee_IDs);

        string Employe4_details=Method5("Sri",9999);
        Console.WriteLine(Employe4_details);//Method5

      int numofLocations=Method6(11);
        Console.WriteLine(numofLocations);//Method6

        
        string[] companies_names=Method7();
        Console.WriteLine(companies_names);//method7
    }
    static string Method1(string companyNAME)
    {
        return companyNAME;
    }
    static string Method2(string Employe1,string Employe2,string Employe3)
    {
        //return Employe1;
        //return Employe2;
        return $"{Employe1},{Employe2} and {Employe3} works in TCS.";
    }

    static int Method3()
    {
        int Company_code = 123;
        return Company_code;
    }
    static int[] Method4()
    {
        int[] Employe_IDs = { 9, 99, 999 };
        foreach(int emp in Employe_IDs)
        {
            Console.WriteLine("list of Employee IDs are: " +emp);
        }
        return Employe_IDs;
    }
    static string Method5(string Employe4,int Employe4_ID)
    {
        return $"{Employe4} is working in DXC and his employee ID is {Employe4_ID}";
    }
    static int Method6(int Company_locations)
    {
        return Company_locations;
        
    }
    static string[] Method7() 
    {
        string[] companies_names = {"TCS","DXC","ITC","CTS" };
        foreach (string company in companies_names) {
            Console.WriteLine(company);
        }
        return companies_names;
    }

}

