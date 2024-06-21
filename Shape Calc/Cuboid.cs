using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calc
{
    internal class Cuboid : Shape3d, IHasVolume
    {
        public Cuboid(double length, double width, double depth) : base(length, width, depth)
        {
        }

        public double Volume()
        {
            return _length * _width * _depth;
        }
    }
}
