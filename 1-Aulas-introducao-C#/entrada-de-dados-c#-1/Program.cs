namespace Course
{

    class Program
    {

        static void Main(string[] args)
        {

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();


            // string  cores = Console.ReadLine();
            // podemos fazer como na linha abaixo para usar menos linhas.
            string[] cores = Console.ReadLine().Split(" ");
            string a, b, c =
            a = cores[0];
            b = cores[1];
            c = cores[2];


            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}