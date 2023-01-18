// See https://aka.ms/new-console-template for more information
using ConsoleApp7;

Console.WriteLine("Exersice 7");

Employee emp = new Employee();
emp.Name = "Nilesh";
emp.Age = 29;
emp.PhoneNumber = "12345678990";
emp.Address = "ABC XYZ flat, Near RYX ,Ahmedabad";
emp.Salary = 33333;
emp.Specialization = "Android";



Manager manager = new Manager();
manager.Name = "ABC";
manager.Age = 35;
manager.PhoneNumber = "9988998800";
manager.Address = "Ahmedabad";
manager.Salary = 32892;
manager.Department = ".Net";

Console.WriteLine("\n=====Employee======\n");
emp.PrintEmployeeDetails();
Console.WriteLine("\n====Manager=====\n");
manager.PrintManagerDetails();
