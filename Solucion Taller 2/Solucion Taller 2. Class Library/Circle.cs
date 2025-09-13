using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Taller_2._Class_Library
{
    public class Circle : GeometricFigure
    {
        // Atributo privado
        private double _r;

        // Propiedad pública para acceder al radio
        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }

        // Constructor
        public Circle(string name, double radius) : base(name)
        {
            R = radius; // usa la propiedad, que valida el valor
        }

        // Método privado para validar el radio
        private double ValidateR(double r)
        {
            if (r <= 0)
                throw new ArgumentException("El radio debe ser mayor que cero.");
            return r;
        }

        // Implementación de los métodos abstractos
        public override double GetArea() => Math.PI * _r * _r;

        public override double GetPerimeter() => 2 * Math.PI * _r;
    }
}
