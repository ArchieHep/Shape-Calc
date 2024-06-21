using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calc
{
    internal abstract class Shape3d : Shape2d
    {
        protected double _depth;
        public Shape3d(double length, double width, double depth) : base(length, width)
        {
            _depth = depth;
        }
    }
}
