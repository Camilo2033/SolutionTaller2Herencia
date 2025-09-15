using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Taller_2._Class_Library
{
    public class Trapeze : Triangle
    {
        private double _d;

        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }

        public Trapeze(string name, double b, double c, double h, double a, double d)
            : base(name, h, c, b, a)
        {
            D = d;
        }

        private double ValidateD(double d)
        {
            if (d <= 0)
                throw new ArgumentException("The value of D must be greater than zero.");
            return d;
        }

        public override double GetArea() => ((A + B) / 2) * H;

        public override double GetPerimeter() => A + B + C + D;
    }
}
