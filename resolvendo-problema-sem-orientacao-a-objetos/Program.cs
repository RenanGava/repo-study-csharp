using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre Com as medidas do triangulo X: ");

            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre Com as medidas do triangulo Y: ");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2;

            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
            Console.WriteLine($"Triangulo X {areaX:F2}");
            Console.WriteLine(p);
            
            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
            Console.WriteLine($"Triangulo Y {areaY:F2}");
            Console.WriteLine(p);
        }
    }
}