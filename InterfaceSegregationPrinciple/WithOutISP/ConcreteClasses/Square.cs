using InterfaceSegregationPrinciple.WithOutISP.Interfaces;

namespace InterfaceSegregationPrinciple.WithOutISP.ConcreteClasses
{
    public class Square : IShape
    {
        private double Height;

        public Square(double height) { Height = height; }

        public double GetArea() { return Height * Height; }

        public double GetVolume() { throw new NotImplementedException(); } // Square doesn't have volume
    }
}
