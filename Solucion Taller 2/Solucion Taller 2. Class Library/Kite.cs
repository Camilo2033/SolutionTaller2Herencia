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

        
        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        
        public Kite(string name, double a, double d1, double d2, double b)
            : base(name, a, d1, d2)   
        {
            B = b;
        }

        
        private double ValidateB(double v)
        {
            if (v <= 0) throw new ArgumentException("The value of B must be greater than zero");
            return v;
        }

       
        public override double GetArea()
        {
            return (D1 * D2) / 2.0;
        }

        
        public override double GetPerimeter()
        {
            return 2.0 * (A + B);
        }
    }
}
