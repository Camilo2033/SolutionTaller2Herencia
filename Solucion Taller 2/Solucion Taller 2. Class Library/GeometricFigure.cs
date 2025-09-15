namespace Solucion_Taller_2._Class_Library
{
    public abstract class GeometricFigure
    {
       
        public string Name { get; set; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

       // Abstract methods that must be implemented by the child classes
        public abstract double GetArea();
        public abstract double GetPerimeter();

        // Overridden ToString method to print results
        public override string ToString()
        {
            return $"{Name,-12} => Area.....: {GetArea(),10:F5}   Perimeter: {GetPerimeter(),10:F5}";
        }
    }
    
}
