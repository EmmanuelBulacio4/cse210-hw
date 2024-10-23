using System;
public class Circle : Shape
{
    private double _radius;

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }
    public override double GetArea()
    {
        
        double cArea = Math.PI*_radius*_radius;
        return cArea;
    }
}