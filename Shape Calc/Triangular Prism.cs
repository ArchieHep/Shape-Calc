using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calc
{
    internal class Triangular_Prism : Shape3d, IHasVolume
    {
        public Triangular_Prism(double length, double width, double depth) : base(length, width, depth)
        {
        }

        public double Volume()
        {
            return ((_length * _width) / 2) * _depth;
        }
    }
}
