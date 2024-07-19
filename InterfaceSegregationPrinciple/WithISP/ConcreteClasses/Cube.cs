using InterfaceSegregationPrinciple.WithISP.Interfaces;

namespace InterfaceSegregationPrinciple.WithISP.ConcreteClasses
{
    public class Cube : ITwoDimensionalShape, IThreeDimensionalShape
    {
        private double Height;

        public Cube(double height) { Height = height; }

        public double GetArea() { return Height * Height; }

        public double GetHeight() { return Height; }

        public double GetVolume() { return 6 * GetArea() * Height; }
    }
}
