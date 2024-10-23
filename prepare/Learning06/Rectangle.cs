using System;
public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public override double GetArea()
    {
        double recArea = _lenght*_width;
        return recArea;
    }
}