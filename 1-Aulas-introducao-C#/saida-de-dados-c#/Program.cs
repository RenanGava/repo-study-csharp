using System;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!"); // inclui quebra de linha na saida do console
            Console.Write("Hello world!");// não inclui a quebra de linha no console
            Console.WriteLine();
            Console.WriteLine("_________________________________________");

            int idade = 32;
            double saldo = 10.35784;
            string nome = "maria";


            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            //dessa forma só dois numeros depois da ","
            Console.WriteLine(saldo.ToString("F2"));
            // formatar saida de dados de acordo com o padrão global
            // assim vai imprimir com o ponto ao invés da virgula.
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("_________________________________________");
            // colocando igual no dois definimos a quantidade de casas decimais.
            Console.WriteLine("{0}, e de idade {1} e com o saldo de {2:F2}",
                nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture
            ));
            // vai dar o mesmo resultado que acima, e podemos fazer da seguinte forma
            Console.WriteLine($"{nome}, e de idade {idade} e com o saldo de {saldo:f2}");
            // e também podemos usara concatenação de valores que funcionará da mesma forma.
            Console.WriteLine(
                nome + "e de idade " + idade + " e com o saldo de " +
                saldo.ToString(
                    "F2",
                    CultureInfo.InvariantCulture
                )
            );

            Console.WriteLine("_________________________________________");

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idadeCliente = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.00;
            double medida = 53.234567;

            Console.WriteLine("Produto:");
            Console.WriteLine($"{produto1}, cujo preço é {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é {preco2:F2}");
            Console.WriteLine("_____________________________________");
            Console.WriteLine($"Registro: {idadeCliente} anos de idade, codigo {codigo} e genero: {genero}");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine($"Medida com oito casas decimais: {medida}");
            Console.WriteLine($"Arredondando (Três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant Culture {medida.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}

