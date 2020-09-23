using System;
class Program
{
    static void Main()
    {
        var square1 = new Square(23.45);
        var square2 = new Square(4);
        var square3 = new Square(12);

        var rectangle = new Rectangle(breadth: 23.5, length: 12.2);
        rectangle.PrintResults();
    }
}
