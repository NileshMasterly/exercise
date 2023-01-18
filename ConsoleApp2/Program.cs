// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exersice 2");

Console.WriteLine("Please enter positive number");
var Var1 = Console.ReadLine();

try
{
    long SwapVariable1 = long.Parse(Var1.Trim());
    int Total = 0;
    foreach (char Charcter in SwapVariable1.ToString())
    {
        Total += Int32.Parse(Charcter.ToString());
    }

    Console.WriteLine("Total of all digit is : " + Total);

}
catch (Exception e)
{
    if (e is FormatException)
    {
        Console.WriteLine("Entered number is not valid");
    }

}
