namespace Course
{

    class Program
    {

        static void Main(string[] args)
        {

            // o new int[] nós instaciamos um vetor e através das chaves
            // nós passamos os valores que ele vai receber.
            int s1 = Calculator.Sum(new int[] { 1, 2, 3, 4, 5 });
            // após colocarmos o params no método Sum podemos passar os valores dessa outra
            // forma também. Sem utilizar new int[] {1, 2, ...}
            int s2 = Calculator.Sum(2, 3, 4, 5, 6 );

            Console.WriteLine(s1); // 15
            Console.WriteLine(s2); // 20
        }
    }
}
