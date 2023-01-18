// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exersice 3");

Console.WriteLine("Please enter number");
var Var1 = Console.ReadLine();

try
{
    long Value = long.Parse(Var1.Trim());
    int Factorial = 1;
    for (int count =1; count <= Value; count++)
    {
        Factorial *= count;
    }

    Console.WriteLine("Total of all digit is : " + Factorial);

}
catch (Exception e)
{
    if (e is FormatException)
    {
        Console.WriteLine("Entered number is not valid");
    }

}