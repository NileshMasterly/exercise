using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Laptop : LaptopBase
    {
        string LaptopName;
        string LaptopRAM;
        string LaptopHarddrive;
        string LaptopPrice;

        public Laptop(string LaptopName,string LaptopRAM,string LaptopHarddrive,string LaptopPrice) {
            this.LaptopPrice = LaptopPrice;
            this.LaptopName = LaptopName;
            this.LaptopRAM = LaptopRAM;
            this.LaptopHarddrive = LaptopHarddrive;
        }

        public void PrintValues()
        {
            Console.WriteLine("Laptopt Name : " +LaptopName +"\nLaptop RAM : " +LaptopRAM +"\nLaptop Harddrive : "+LaptopHarddrive + "\nLaptop Price : "+LaptopPrice);
        }
    }
}
