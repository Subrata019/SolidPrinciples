using LiskovSubstitutionPrinciple.Case1.WithLSP.Interfaces;
using LiskovSubstitutionPrinciple.Case1.WithLSP.ConcreteClasses;
using WithOutLSPBird = LiskovSubstitutionPrinciple.Case1.WithOutLSP.Bird;
using WithOutLSPPenguin = LiskovSubstitutionPrinciple.Case1.WithOutLSP.Penguin;
using WithOutLSPSparrow = LiskovSubstitutionPrinciple.Case1.WithOutLSP.Sparrow;
using LiskovSubstitutionPrinciple.Case2.WithLSP;
using WithOutLSPBeverageItem = LiskovSubstitutionPrinciple.Case2.WithOutLSP.BeverageItem;
using WithOutLSPMenuItem = LiskovSubstitutionPrinciple.Case2.WithOutLSP.MenuItem;


// Case 1: Derived class inherits a class which it cannot implement.
Console.WriteLine("**********  Case 1 with out Liskov Substitution Principle  **********");

Console.WriteLine("Sparrow:");
WithOutLSPBird withOutLSPSparrow = new WithOutLSPSparrow();
withOutLSPSparrow.Walk();
withOutLSPSparrow.Fly();

Console.WriteLine("Penguin:");
WithOutLSPBird withOutLSPPenguin = new WithOutLSPPenguin();
withOutLSPPenguin.Walk();
//withOutLSPPenguin.Fly(); // breaks Liskov substitution principle


Console.WriteLine("\n\n**********    Case 1 with Liskov Substitution Principle    **********");

Console.WriteLine("Sparrow:");
IBird sparrow = new Sparrow();
sparrow.Move();

Console.WriteLine("Penguin:");
IBird penguin = new Penguin();
penguin.Move();


// Case 2: Derived class has methods base class doesn't
Console.WriteLine("\n\n\n**********  Case 2 with out Liskov Substitution Principle  **********");

WithOutLSPBeverageItem withOutBeverageItem = new("Cola", 30, "Cold drinks");
Console.WriteLine("Beverage item price: " + withOutBeverageItem.GetPriceWithDiscount());

// Reference to derived class is replaced with base class
WithOutLSPMenuItem withOutMenuItem = new WithOutLSPBeverageItem("Cola", 30, "Cold drinks");
//Console.WriteLine("Beverage item price" + withOutMenuItem.GetPriceWithDiscount()); // this error is because Liskov substitution principle is violated


Console.WriteLine("\n\n**********    Case 2 with Liskov Substitution Principle    **********");

BeverageItem beverageItem = new("Cola", 30, "Cold drinks");
Console.WriteLine("Beverage item discount via derived class: " + beverageItem.GetDiscount());

// Reference to derived class is replaced with base class
MenuItem menuItem = new BeverageItem("Cola", 30, "Cold drinks");
Console.WriteLine("Beverage item discount via base class: " + menuItem.GetDiscount());


