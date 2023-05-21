using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_class
{
    internal class Figure
    {
        private Point sides;
        public Figure(in int sideA, in int sideB, in int sideC)
        {
            sides.sideA = sideA;
            sides.sideB = sideB;
            sides.sideC = sideC;
        }

        public Point GetSides() => sides;
        public int FindPerimetr() => sides.sideA + sides.sideB + sides.sideC;
        public int FindSquare()
        {
            int halphPerimetr;
            halphPerimetr = (sides.sideA + sides.sideB + sides.sideC) / 2;

            int s = halphPerimetr * (halphPerimetr - sides.sideA) *
                (halphPerimetr - sides.sideB) * (halphPerimetr - sides.sideC);

            return Convert.ToInt32(Math.Sqrt(s));
        }
    }
}
