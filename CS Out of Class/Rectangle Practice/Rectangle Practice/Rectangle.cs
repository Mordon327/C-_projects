using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Practice
{
    class Rectangle
    {
        double sideA, sideB;

        public Rectangle()
        {
            sideA = 0;
            sideB = 0;
        }

        public Rectangle(double sa, double sb)
        {
            sideA = sa;
            sideB = sb;
        }

        public double GetSideA ()
        {
            return sideA;
        }

        public void SetSideA (double va)
        {
            sideA = va;
        }

    }
}
