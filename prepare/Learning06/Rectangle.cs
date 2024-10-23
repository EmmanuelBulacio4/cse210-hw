using System;
public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public void SetLenght(double lenght)
    {
        _lenght = lenght;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }

    public double GetLenght()
    {
        return _lenght;
    }

    public double GetWidth()
    {
        return _width;
    }

    public override double GetArea()
    {
        double recArea = _lenght*_width;
        return recArea;
    }
}