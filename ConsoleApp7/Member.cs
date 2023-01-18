using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Member
    {
        string Name;
        int Age;
        string PhoneNumber;
        string Address;
        long Salary;


        public void PrintSalary()
        {
            Console.WriteLine(Salary.ToString());
        }

    }
}
