using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Taller_2._Class_Library
{
    public class Circle : GeometricFigure
    {
        // Private attribute
        private double _r;

        //  Public property to access the radius
        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }

        // Constructor
        public Circle(string name, double radius) : base(name)
        {
            R = radius; 
        }

        // Private method to validate the radius
        private double ValidateR(double r)
        {
            if (r <= 0)
                throw new ArgumentException("The radius must be greater than zero.");
            return r;
        }

        // Implementation of abstract methods
        public override double GetArea() => Math.PI * _r * _r;

        public override double GetPerimeter() => 2 * Math.PI * _r;
    }
}
