using System;
public class Circle : Shape
{
    private double _radius;
    public const double PI = 3.1415926535897931;

    public override double GetArea()
    {
        
        double cArea = PI*_radius*_radius;
        return cArea;
    }
}