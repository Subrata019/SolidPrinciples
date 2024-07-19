using LiskovSubstitutionPrinciple.Case1.WithLSP.Interfaces;

namespace LiskovSubstitutionPrinciple.Case1.WithLSP.ConcreteClasses
{
    public class FlyingBird : IBird
    {
        public void Move() { Console.WriteLine("Can fly"); }
    }
}
