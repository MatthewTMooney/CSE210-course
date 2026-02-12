using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("Red", 4);
        Rectangle rect = new Rectangle("Blue", 5, 3);
        Circle circ = new Circle("Green", 2.5);

        Console.WriteLine("Square Color: " + sq.GetColor());
        Console.WriteLine("Square Area: " + sq.GetArea());

        Console.WriteLine("Rectangle Color: " + rect.GetColor());
        Console.WriteLine("Rectangle Area: " + rect.GetArea());

        Console.WriteLine("Circle Color: " + circ.GetColor());
        Console.WriteLine("Circle Area: " + circ.GetArea());

        List<Shape> stuff = new List<Shape>();

        stuff.Add(sq);
        stuff.Add(rect);
        stuff.Add(circ);

        Console.WriteLine("\nList Output:");

        foreach (Shape s in stuff)
        {
            Console.WriteLine("Color: " + s.GetColor() + " Area: " + s.GetArea());
        }
    }
}