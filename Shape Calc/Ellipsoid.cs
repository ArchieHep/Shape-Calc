using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calc
{
    internal class Ellipsoid : Shape3d, IHasVolume
    {
        public Ellipsoid(double length, double width, double depth) : base(length, width, depth)
        {
        }

        public double Volume()
        {
            return (4.0 / 3.0) * Math.PI * (_length / 2) * (_width / 2) * (_depth / 2);
        }
    }
}
