using System.Globalization;

namespace Course{

    class Program{

        static void Main(string[] args){

            Produto p = new Produto();

            System.Console.Write("Entre os dados do produto");
            System.Console.Write("Nome do produto: ");
            p.Nome = Console.ReadLine();
            System.Console.Write("Preco do Produto: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantidade do Produto: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // podemos passar o "p" dessa forma por nós mudarmos como o toString funciona
            // dentro da classe Produto.
            System.Console.WriteLine("Dados Do Produto: "+ p);
            
            // depois de adicionar produtos ao estoque
            System.Console.Write("Adicione Maisn Quantidade de Produto em Estoque: ");
            int AddQuant = int.Parse(Console.ReadLine());
            p.AddProdutoQuantidade(AddQuant);
            System.Console.WriteLine("Dados Atualizados Produto: "+ p);

            // depois de remover produtos ao estoque
            System.Console.Write("Remover Quantidade de Produto em Estoque: ");
            int rmQuant = int.Parse(Console.ReadLine());
            p.RemoveProdutoQuantidade(rmQuant);
            System.Console.WriteLine("Dados Atualizados Produto: "+ p);
        }
    }
}