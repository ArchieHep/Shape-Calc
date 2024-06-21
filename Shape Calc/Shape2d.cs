using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calc
{
    internal abstract class Shape2d
    {
        protected double _length, _width;

        public Shape2d(double length, double width)
        {
            _length = length;
            _width = width;

        }

    }
}
