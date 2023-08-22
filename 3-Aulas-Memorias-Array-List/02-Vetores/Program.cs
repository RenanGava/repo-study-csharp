using System.Globalization;

namespace Name
{
    class Program
    {
        static void Main(string[] args){

            Console.WriteLine("Digite um Número: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite ua Altura: ");
            double altura = double.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n ; i++){
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine(vect[i]);
            }

            
        
        }
    }
    
}