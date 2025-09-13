using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Taller_2._Class_Library
{
    public class Kite : Rhombus
    {
        private double _b;

        // Propiedad pública según UML
        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        // Constructor: (name, a, b, d1, d2)
        public Kite(string name, double a, double b, double d1, double d2)
            : base(name, a, d1, d2)   // Rhombus(name, a, d1, d2) -> deja A, D1, D2
        {
            B = b;
        }

        // Validación privada
        private double ValidateB(double v)
        {
            if (v <= 0) throw new ArgumentException("El valor de B debe ser mayor que cero.");
            return v;
        }

        // Área: usa las diagonales D1 y D2 (heredadas de Rhombus)
        public override double GetArea()
        {
            return (D1 * D2) / 2.0;
        }

        // Perímetro: kite tiene pares de lados iguales -> 2*(A + B)
        // A viene heredada de Square (propiedad pública), B es propia
        public override double GetPerimeter()
        {
            return 2.0 * (A + B);
        }
    }
}
