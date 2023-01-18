// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exersice 4");
Console.WriteLine("Please enter number");
 

try
{
    int Fibonacci = Int32.Parse(Console.ReadLine()?.Trim() ?? "0");
    int i = 0, i1 = 1, i3;
    Console.Write(i + " " + i1 + " ");
    for (int count = 2; count < Fibonacci; count++)
    {
        i3 = i + i1;
        Console.Write(i3 + " ");
        i = i1;
        i1 = i3;
    }

   // Console.WriteLine("Total of all digit is : " + Factorial);

}
catch (Exception e)
{
    if (e is FormatException)
    {
        Console.WriteLine("Entered number is not valid");
    }

}
