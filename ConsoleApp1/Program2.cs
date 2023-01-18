using System;

namespace hello;

class Program2
{
    static void main(string[] args)
    {


        Console.WriteLine("Exersice 2");

        Console.WriteLine("Please enter positive number");
        var Var1 = Console.ReadLine();

        try
        {
            int SwapVariable1 = Convert.ToInt32(Var1);
            int Total = 0;
            foreach(var Charcter in SwapVariable1.ToString())
            {
                Total += Convert.ToInt16(Charcter);
            }

            Console.WriteLine("Total of all digit is : " + Total);

        }
        catch (Exception e)
        {
            if(e is FormatException) {
                Console.WriteLine("Entered number is not valid");
            }
            
        }
    }
}
