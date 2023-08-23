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

        // passando o this dessa forma referenciamos o construtor da classe
        public Produto(string nome, double preco): this(){
            this.Nome = nome;
            this.Preco = preco;
            
        }
        
        // se passarmos parametros ele utilizara os parametros do construtor que possuir esses
        // valores delcarados e vai passar para o outro construtor dentro das classe
        public Produto(string nome, double preco, int quantidade): this(nome, preco){
            // e podemos usar como na forma abaixo para diferenciar argumentos de escopo do
            // método para atributos da classe quando chamados.
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