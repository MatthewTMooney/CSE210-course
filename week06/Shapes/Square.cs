using System;

public class Square : Shape
{
    private double sideLen;

    public Square(string color, double s) : base(color)
    {
        sideLen = s;
    }

    public override double GetArea()
    {
        double result = sideLen * sideLen;
        return result;
    }
}
