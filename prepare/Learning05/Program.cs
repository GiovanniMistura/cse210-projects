using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {

        Square square = new Square("green",5.5);
        Rectangle rectangle = new Rectangle("blue",6.7,3.5);
        Circle circle = new Circle("pink",2.8);
        List<Shape> shapes = new List<Shape>(){square,rectangle,circle};

        foreach (Shape shape in shapes)
        {
             Console.WriteLine("Color: " + shape.GetColor() + " - Area: " + shape.GetArea());
        }
    }
}