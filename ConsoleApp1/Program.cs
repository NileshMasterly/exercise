// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Exersice 1");

Console.WriteLine("Please enter number");
var var1 = Console.ReadLine();
Console.WriteLine("Please enter number");
var var2 = Console.ReadLine();

try
{
    int swapVariable1 = Convert.ToInt32(var1);
    int swapVariable2 = Convert.ToInt32(var2);

    Console.WriteLine("First Variable Values is: " + swapVariable1.ToString() + " and second Variable values is: " + swapVariable2.ToString());
    swapVariable1 = swapVariable2 + swapVariable1;
    swapVariable2 = swapVariable1 - swapVariable2;
    swapVariable1 = swapVariable1 - swapVariable2;
    Console.WriteLine("After swapping, First Variable Values is: " + swapVariable1.ToString() + " and second Variable  values is" + swapVariable2.ToString());

}
catch (Exception e)
{
    Console.WriteLine("Entered number is not valid");
    Console.WriteLine(e.ToString());
}