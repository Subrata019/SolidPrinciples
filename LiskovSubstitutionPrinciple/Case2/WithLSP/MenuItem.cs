namespace LiskovSubstitutionPrinciple.Case2.WithLSP
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public MenuItem(string name, double price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        public double GetPrice() { return Price - GetDiscount(); }

        public double GetDiscount() { return 0; }
    }
}
