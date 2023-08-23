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


            // podemos passar os valores para os paremetros da classe produto
            // dessa forma também, vai funcionar mesmo que a classe nào tenha construtores.

            // OBS: se nào for definido um construtor sem para metros a sintaxe alternativa
            // dará erro.

            Produto p = new Produto() {
                Nome = nome,
                Preco = preco,
                Quantidade = quantidade
            };
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