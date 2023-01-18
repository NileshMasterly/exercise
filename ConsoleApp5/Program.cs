// See https://aka.ms/new-console-template for more information



using ConsoleApp5;

Console.WriteLine("Exersice 5");

Laptop laptop1 = new Laptop(Laptop.LaptopName.Dell, Laptop.RAM.RAM8, Laptop.HARDDRIVE.HARDDRIVE512, Laptop.Price.LOW);
Laptop laptop2 = new Laptop(Laptop.LaptopName.LENOVO, Laptop.RAM.RAM16, Laptop.HARDDRIVE.HARDDRIVE256, Laptop.Price.K12);
Laptop laptop3 = new Laptop(Laptop.LaptopName.MAC, Laptop.RAM.RAM4, Laptop.HARDDRIVE.HARDDRIVE128, Laptop.Price.HIGH);

laptop1.PrintValues();
Console.WriteLine("\n\n");
laptop2.PrintValues();
Console.WriteLine("\n\n");
laptop3.PrintValues();
