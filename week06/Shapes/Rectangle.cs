using System;

public class Rectangle : Shape
{
    private double len1;
    private double len2;

    public Rectangle(string color, double l, double w) : base(color)
    {
        len1 = l;
        len2 = w;
    }

    public override double GetArea()
    {
        return len1 * len2;
    }
}
