using InterfaceSegregationPrinciple.WithOutISP.Interfaces;
using WithOutISPSqure = InterfaceSegregationPrinciple.WithOutISP.ConcreteClasses.Square;
using WithOutISPCube = InterfaceSegregationPrinciple.WithOutISP.ConcreteClasses.Cube;
using InterfaceSegregationPrinciple.WithISP.Interfaces;
using InterfaceSegregationPrinciple.WithISP.ConcreteClasses;


Console.WriteLine("**********  With out Interface Segregation Principle  **********");

IShape withOutISPSqure = new WithOutISPSqure(10);
Console.WriteLine("Area of Square: " + withOutISPSqure.GetArea());
//Console.WriteLine("Volume of Square: " + withOutISPSqure.Volume()); // breaks Liskov Subsititution Principle & Interface Segregation Principle

IShape withOutISPCube = new WithOutISPCube(10);
Console.WriteLine("Area of Cube: " + withOutISPCube.GetArea());
Console.WriteLine("Volume of Cube: " + withOutISPCube.GetVolume());


Console.WriteLine("\n\n**********    With Interface Segregation Principle    **********");

ITwoDimensionalShape square = new Square(10);
Console.WriteLine("Area of Square: " + square.GetArea());

ITwoDimensionalShape cubeA = new Cube(10);
Console.WriteLine("Area of Cube: " + cubeA.GetArea());

IThreeDimensionalShape cubeV = new Cube(10);
Console.WriteLine("Volume of Cube: " + cubeV.GetVolume());

