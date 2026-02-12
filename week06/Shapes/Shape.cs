using System;

public class Shape
{
    private string c;

    public Shape(string color)
    {
        c = color;
    }

    public string GetColor()
    {
        return c;
    }

    public void SetColor(string newColor)
    {
        c = newColor;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}
