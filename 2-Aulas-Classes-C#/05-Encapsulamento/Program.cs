using System.Globalization;

namespace Course{

    class Program{

        static void Main(string[] args){
            
            Produto p = new Produto("TV", 500.00, 10);
            Console.WriteLine(p.GetNome());
            p.SetNome(nome:"Cv"); // mudamos o nome do parametro usando este método
            Console.WriteLine(p.GetNome(), p.GetPreco());
            
        }
    }
}