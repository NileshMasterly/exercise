using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class LaptopBase
    {
        public class LaptopName
        {
            public const string LENOVO = "Lenovo";
            public const string MSI = "MSI";
            public const string Dell = "Dell";
            public const string HP = "HP";
            public const string MAC = "MAC";

        }
        public class Price
        {
            public const string LOW = "10k";
            public const string HIGH = "20k";
            public const string MID = "15k";
            public const string K12 = "12K";
        }

        public class RAM
        {
            public const string RAM12   = "RAM 12GB";
            public const string RAM8 = "RAM 8GB";
            public const string RAM16 = "RAM 16GB";
            public const string RAM4 = "RAM 4GB";
        }

        public class HARDDRIVE
        {
            public const string HARDDRIVE512 = "HARDDRIVE 512GB";
            public const string HARDDRIVE128 = "HARDDRIVE 128GB";
            public const string HARDDRIVE256 = "HARDDRIVE 256GB";
        }

    }
}
