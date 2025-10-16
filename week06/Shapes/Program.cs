using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of shapes (polymorphism)
        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 3),
            new Rectangle("Blue", 4, 5),
            new Circle("Green", 6),
            
        };

        // Display color and area for each shape
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea():F2}");
        }
    }
}