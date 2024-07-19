using InterfaceSegregationPrinciple.WithISP.Interfaces;

namespace InterfaceSegregationPrinciple.WithISP.ConcreteClasses
{
    public class Square : ITwoDimensionalShape
    {
        private double Height;

        public Square(double height) { Height = height; }

        public double GetArea() { return Height * Height; }

        public double GetHeight() { return Height; }
    }
}
