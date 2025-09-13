using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Taller_2._Class_Library
{
    public class Rectangle : Square
    {
        private double _b;

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }

        private double ValidateB(double b)
        {
            if (b <= 0)
                throw new ArgumentException("El valor de B debe ser mayor que cero.");
            return b;
        }

        public override double GetArea() => A * B;
        public override double GetPerimeter() => 2 * (A + B);
    }
}
