using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calc
{
    internal class Rectangle : Shape2d, IHasArea
    {
        public Rectangle(double length, double width) : base(length, width)
        {
        }

        public double Area()
        {
            return _length * _width;
        }
    }
}
