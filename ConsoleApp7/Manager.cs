using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    
    class Manager : Member
    {
        
        public string Department;

        public void PrintManagerDetails()
        {
            var info = GetInfoInString();
            info += "\nDepartment: " + Department;
            Console.WriteLine(info);
        }
    }
}
