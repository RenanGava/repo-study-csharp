using System.Globalization;


namespace Name
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio");

            Calculadora calc = new Calculadora();

            CultureInfo fomatedInput = CultureInfo.InvariantCulture;

            double raio = double.Parse(Console.ReadLine(), fomatedInput);

            double circ = calc.CalcCircunferencia(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", fomatedInput));

            double vol = calc.CalcVolume(raio);

            Console.WriteLine("Volume: " + vol.ToString("F2", fomatedInput));
            Console.WriteLine("Valor de PI: " + calc.PI.ToString("F2", fomatedInput));

        }

        
    }
}