// See https://aka.ms/new-console-template for more information
using shapelib;

Console.WriteLine("Hello, World!");

//"Shape s1 = new circle()");
//"shape s2 =  new recatangle()");
//"call all the function and print output");
circle s1 = new circle();
s1.radius = 5;
Console.WriteLine(s1.draw());
Console.WriteLine(s1.getdetails()); 
Console.WriteLine("\n");

rectangle r1 = new rectangle();
r1.length = 4;
r1.breadth = 5;
Console.WriteLine(r1.draw());
Console.WriteLine(r1.getdetails());
Console.WriteLine("\n");

