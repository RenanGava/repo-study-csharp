using System.Globalization;

namespace Course{

    class Program{

        static void Main(string[] args){
            // int n1 = int.Parse(Console.ReadLine());
            // char ch = char.Parse(Console.ReadLine());
            // double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(" ");
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            System.Console.WriteLine("Voce digitou");
            // System.Console.WriteLine(n1);
            // System.Console.WriteLine(ch);
            // System.Console.WriteLine(n2);
            System.Console.WriteLine(nome);
            System.Console.WriteLine(sexo);
            System.Console.WriteLine(idade);
            System.Console.WriteLine(altura);
        }
    }
}