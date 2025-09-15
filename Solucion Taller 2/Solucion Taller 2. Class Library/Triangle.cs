using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Taller_2._Class_Library
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public Triangle(string name, double b, double c, double a, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }

        private double ValidateC(double c)
        {
            if (c <= 0)
                throw new ArgumentException("The value of C must be greater than zero.");
            return c;
        }

        private double ValidateH(double h)
        {
            if (h <= 0)
                throw new ArgumentException("The value of H must be greater than zero.");
            return h;
        }

        public override double GetArea() => (C * H) / 2;

        
        public override double GetPerimeter() => A + B + C;
    }
}
