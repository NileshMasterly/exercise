using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Member
    {
        public string Name;
        public int Age;
        public string PhoneNumber;
        public string Address;
        public long Salary;


        public void PrintSalary()
        {
            Console.WriteLine(Salary.ToString());
        }

        public string GetInfoInString()
        {
            string str = "Name: "+Name+"\nAge: "+Age+"\nPhone Number: "+PhoneNumber +"\nAddress: "+Address+"\nSalary: "+Salary;

            return str;
        }

    }
}
