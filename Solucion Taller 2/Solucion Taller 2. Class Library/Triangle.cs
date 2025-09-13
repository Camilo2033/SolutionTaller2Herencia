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

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }

        private double ValidateC(double c)
        {
            if (c <= 0)
                throw new ArgumentException("El valor de C debe ser mayor que cero.");
            return c;
        }

        private double ValidateH(double h)
        {
            if (h <= 0)
                throw new ArgumentException("El valor de H debe ser mayor que cero.");
            return h;
        }

        public override double GetArea() => (C * H) / 2;

        // Aquí el perímetro depende del diagrama; pongo un ejemplo genérico
        public override double GetPerimeter() => A + B + C;
    }
}
