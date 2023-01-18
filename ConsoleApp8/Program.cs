// See https://aka.ms/new-console-template for more information
using ConsoleApp8;

Console.WriteLine("Exersice 8\n ======");
Console.WriteLine("Enter height to know Area and perimeter of Square");
var height = float.Parse(Console.ReadLine()??"0");

Square square = new Square(height);
Console.WriteLine("Perimeter of square is"+square.GetPerimeter());
Console.WriteLine("Area of square is" + square.GetArea());


Console.WriteLine("Enter width to know Area and perimeter of Rectangle \n");
var width = float.Parse(Console.ReadLine() ?? "0");

Square square1 = new Square(height,width);
square1.PrintRectanglevalue();



