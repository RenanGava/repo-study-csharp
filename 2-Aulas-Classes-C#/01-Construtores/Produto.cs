using System.Globalization;

namespace Course{

    class Produto{

        public string Nome = "";
        public double Preco;
        public int Quantidade;


        // isso é um construtor em C#
        public Produto(string nome, double preco, int quantidade){
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;

        }

        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }

        //oq vamos aprender aqui é sobreposiçào que será explicado melhora mais para frente
        // do curso usando a palavra override
        public override string ToString()
        {   // o base é referido a nossa classe Produto ou qualquer
            // outra classe que fizermos isso. 
            return Nome 
            + ", " 
            +  "$ " 
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " Uninades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AddProdutoQuantidade(int addQuant){
            Quantidade += addQuant;
        }
        public void RemoveProduto(int rmQuant){
            Quantidade -= rmQuant;
        }
    }
}