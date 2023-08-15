using System.Globalization;

namespace Course{

    class Program{

        static void Main(string[] args){

            Produto p = new Produto();

            System.Console.WriteLine("Entre os dados do produto");
            System.Console.WriteLine("Nome do produto");
            p.Nome = Console.ReadLine();
            System.Console.WriteLine("Preco do Produto");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Quantidade do Produto");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine($"Dados do Produto: Nome{p.Nome}, Preço: {p.Preco}, Quant: {p.Quantidade}");
            System.Console.WriteLine("Valor total estoque"+ p.ValorTotalEmEstoque());
        }
    }
}