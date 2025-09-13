namespace Solucion_Taller_2._Class_Library
{
    public abstract class GeometricFigure
    {
        // Propiedad común
        public string Name { get; set; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

        // Métodos abstractos que deben implementar las clases hijas
        public abstract double GetArea();
        public abstract double GetPerimeter();

        // Método ToString sobrescrito para imprimir resultados
        public override string ToString()
        {
            return $"{Name,-12} => Area.....: {GetArea(),10:F5}   Perimeter: {GetPerimeter(),10:F5}";
        }
    }
    
}
