using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calc
{
    internal class Ellipse : Shape2d, IHasArea
    {
        public Ellipse(double length, double width) : base(length, width)
        {
        }

        public double Area()
        {
            return Math.PI * (_length / 2) * (_width / 2);
        }
    }
}
