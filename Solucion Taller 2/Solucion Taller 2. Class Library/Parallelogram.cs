using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Taller_2._Class_Library
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public Parallelogram(string name, double b, double a, double h) : base(name, a, b)
        {
            H = h;
        }

        private double ValidateH(double h)
        {
            if (h <= 0)
                throw new ArgumentException("The value of H must be greater than zero.");
            return h;
        }

        public override double GetArea() => A * H;

        public override double GetPerimeter() => 2 * (A + B);
    }
}
