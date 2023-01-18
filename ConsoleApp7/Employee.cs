using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Employee : Member
    {
        public string Specialization;

        public void PrintEmployeeDetails()
        {
            var info = GetInfoInString();
            info += "\nspecialization: " + Specialization;
            Console.WriteLine(info);
        }
    }
}
