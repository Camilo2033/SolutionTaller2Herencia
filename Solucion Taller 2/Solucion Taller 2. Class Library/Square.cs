using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Taller_2._Class_Library
{
    public class Square : GeometricFigure
    {
        private double _a;

        public double A
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        public Square(string name, double a) : base(name)
        {
            A = a;
        }

        private double ValidateA(double v)
        {
            if (v <= 0)
                throw new ArgumentException("The value must be greater than zero.");
            return v;
        }

        public override double GetArea() => _a * _a;
        public override double GetPerimeter() => 4 * _a;
    }
}
