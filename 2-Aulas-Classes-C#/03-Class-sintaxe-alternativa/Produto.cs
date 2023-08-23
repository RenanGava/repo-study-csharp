using System.Globalization;

namespace Course{

    class Produto{

        public string Nome = "";
        public double Preco;
        public int Quantidade;


        // passando o construtor vaxzio dessa forma dizemos que
        // nossa classe não precisa receber parametros
        public Produto(){

        }

        // // isso é um construtor em C#
        // public Produto(string nome, double preco, int quantidade){
        //     this.Nome = nome;
        //     this.Preco = preco;
        //     this.Quantidade = quantidade;

        // }

        // // a sobre carga é nada mais que um novo construtor
        // // que nós passamos parametros diferentes para dentro de nossa classe.
        // // podemos criar vários utilizando sobre carga.
        public Produto(string nome, double preco){
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = 5;
            // linha dispensavel pois o atributos númericos recebem zero por padrão 
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