using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative015_EngineerSpock_Overload
{
    public class Formules
    {
        public double CalcSquare(double side1, double side2, double side3)
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public double CalcSquare(double b, double h)
        {
            return 0.5 * b * h;
        }

        public double CalcSquare(double side1, double side2, int corner)
        {
            double rads = corner * Math.PI / 180;
            return 0.5 * side1 * side2 * Math.Sin(rads);
        }
    }
}
