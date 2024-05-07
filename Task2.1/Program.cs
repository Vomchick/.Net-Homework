namespace Task2._1;

internal class Program
{
    static void Main(string[] args)
    {
        var point1 = new Point()
        {
            X = 1,
            Y = 2,
            Z = 3,
            Mass = 4f
        };

        var point2 = new Point()
        {
            X = 7,
            Y = 1,
            Z = 3,
            Mass = 5f
        };

        Console.WriteLine(point1.Distance(point2));
        Console.WriteLine(point2.Distance(point1));
        Console.WriteLine(point1.Distance(point1));

        Console.WriteLine(point1.IsZero());
        point1.X = 0;
        point1.Y = 0;
        point1.Z = 0;
        Console.WriteLine(point1.IsZero());

    }
}
