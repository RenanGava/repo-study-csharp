using System.Globalization;

namespace Course{

    class Program{

        static void Main(string[] args){
            
            Console.Write("Entre os dados do produto");
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Preco do Produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade do Produto: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            // como estamos usando um construtor devemos utilizar a classe dessa forma.

            // Produto p = new Produto(nome, preco, quantidade);

            // criando mais de um construtor na classe podemos colocar diferentes
            // quantidades de parametros a serem passados

            Produto p = new Produto(nome, preco);

            Console.WriteLine("Dados Do Produto: "+ p);
            
            // depois de adicionar produtos ao estoque
            Console.Write("Adicione Maisn Quantidade de Produto em Estoque: ");
            int AddQuant = int.Parse(Console.ReadLine());
            p.AddProdutoQuantidade(AddQuant);
            Console.WriteLine("Dados Atualizados Produto: "+ p);

            // depois de remover produtos ao estoque
            Console.Write("Remover Quantidade de Produto em Estoque: ");
            int rmQuant = int.Parse(Console.ReadLine());
            p.RemoveProduto(rmQuant);
            Console.WriteLine("Dados Atualizados Produto: "+ p);
            
        }
    }
}