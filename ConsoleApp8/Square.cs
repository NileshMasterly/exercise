using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Square : Rectangle
    {

        public Square(float length) : base(length, length) { 
        }
        
        public Square(float height, float width) : base(height , width)
        {
            

        }

        public void PrintRectanglevalue()
        {
            Console.WriteLine("\nPerimeter of square is" + this.GetPerimeter());
            Console.WriteLine("\nArea of square is" + this.GetArea());
        }

       


    }
}
