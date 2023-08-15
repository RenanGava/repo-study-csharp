namespace Course
{

    class Program
    {

        static void Main(string[] args)
        {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            System.Console.WriteLine("Digite os comprimentos do lado do triangulo X. ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite os comprimentos do lado do triangulos Y. ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            Triangulo area = new Triangulo();
            
            System.Console.WriteLine("area traingulo Y: " + y.CalcAreaTriangulo());
            System.Console.WriteLine("area traingulo X: " + x.CalcAreaTriangulo());
        }
    }
}