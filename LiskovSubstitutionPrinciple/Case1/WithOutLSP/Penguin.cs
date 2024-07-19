namespace LiskovSubstitutionPrinciple.Case1.WithOutLSP
{
    public class Penguin : Bird
    {
        public new void Fly() { throw new NotImplementedException(); }

        // inherits the Walk method from Bird
    }
}
