using System;
public class Circle : Shape
{
    private double _radius;
    public const double PI = 3.1415926535897931;

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
        
        double cArea = PI*_radius*_radius;
        return cArea;
    }
}