using System;
public class Square : Shape
{
    private double _side;

    public override double GetArea()
    {
        double sqArea = _side*_side;
        return sqArea;
    }

}