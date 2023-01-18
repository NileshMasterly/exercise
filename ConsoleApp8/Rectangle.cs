using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Rectangle
    {
        public float length;
        public float breadth;

        public Rectangle(float length, float breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public float GetPerimeter()
        {
            return (length + breadth) *2 ;
        }

        public float GetArea()
        {
            return (length * breadth);
        }
    }
}
