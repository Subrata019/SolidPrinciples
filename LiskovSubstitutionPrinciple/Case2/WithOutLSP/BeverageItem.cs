namespace LiskovSubstitutionPrinciple.Case2.WithOutLSP
{
    public class BeverageItem : MenuItem
    {
        public BeverageItem(string name, double price, string description) : base(name, price, description) { }

        // inherits the GetPrice method from MenuItem

        public double GetPriceWithDiscount() { return Price - (Price * 10 / 100); } // 10% discount
    }
}
