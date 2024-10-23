using System;
public class Square : Shape
{
    private double _side;

    public Square()
    {
    }

    public void SetSide(double side)
    {
        _side = side;
    }

    public double GetSide()
    {
        return _side;
    }

    public override double GetArea()
    {
        double sqArea = _side*_side;
        return sqArea;
    }

}