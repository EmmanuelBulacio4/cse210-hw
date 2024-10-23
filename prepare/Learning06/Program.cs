using System;

class Program
{
    static void Main(string[] args)
    {
        Square cuadrado = new Square();
        cuadrado.SetColor("blue");
        cuadrado.SetSide(6);
        
        Rectangle rectangulo = new Rectangle();
        rectangulo.SetColor("yellow");
        rectangulo.SetLenght(2);
        rectangulo.SetWidth(3);

        Circle circulo = new Circle();
        circulo.SetColor("green");
        circulo.SetRadius(5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(cuadrado);
        shapes.Add(rectangulo);
        shapes.Add(circulo);

        foreach (Shape shape in shapes)
        {
            double superficie = shape.GetArea();
            Console.WriteLine(superficie);
        }

    }
}