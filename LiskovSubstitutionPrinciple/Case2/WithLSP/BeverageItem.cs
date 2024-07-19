namespace LiskovSubstitutionPrinciple.Case2.WithLSP
{
    public class BeverageItem : MenuItem
    {
        public BeverageItem(string name, double price, string description) : base(name, price, description) { }

        // inherits the GetPrice method from MenuItem

        public new double GetDiscount() { return Price * 10 / 100; } // 10% discount
    }
}
