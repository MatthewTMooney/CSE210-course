using System;

public class Circle : Shape
{
    private double rVal;

    public Circle(string color, double r) : base(color)
    {
        rVal = r;
    }

    public override double GetArea()
    {
        double areaThing = Math.PI * rVal * rVal;
        return areaThing;
    }
}
