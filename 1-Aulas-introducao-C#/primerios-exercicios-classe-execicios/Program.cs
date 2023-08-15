namespace Course{


    class Program{


        static void Main(string[] args){

            Pessoa Pessoa1 = new Pessoa();
            Pessoa Pessoa2 = new Pessoa();

            System.Console.WriteLine("Digite o Nome da primeira pessoa");
            Pessoa1.name = Console.ReadLine();
            System.Console.WriteLine("Digite a idade da primeira pessoa");
            Pessoa1.idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Nome da segunda pessoa");
            Pessoa2.name = Console.ReadLine();
            System.Console.WriteLine("Digite a idade da segunda pessoa");
            Pessoa2.idade = int.Parse(Console.ReadLine());

            if( Pessoa1.idade < Pessoa2.idade){
                System.Console.WriteLine($"Pessoa mais velha: {Pessoa2.name}");
            }else{
                System.Console.WriteLine($"Pessoa mais velha: {Pessoa1.name}");
            }
        }
    }
}