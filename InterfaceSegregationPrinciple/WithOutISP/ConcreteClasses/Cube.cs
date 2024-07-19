using InterfaceSegregationPrinciple.WithOutISP.Interfaces;

namespace InterfaceSegregationPrinciple.WithOutISP.ConcreteClasses
{
    public class Cube : IShape
    {
        private double Height;

        public Cube(double height) { Height = height; }

        public double GetArea() { return Height * Height; }

        public double GetVolume() { return 6 * GetArea(); }
    }
}
