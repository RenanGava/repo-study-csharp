using System.Globalization;

namespace Course
{

    class Produto
    {


        // encapsulamento significa colocar alguns atributos
        // como privado para que não tenha interação direto com eles
        // por serem dados sensiveis podemos criar métodos para eles serem alterados ou
        // recuperar seu conteúdo com GET e SET exemplos no código GetNome e SetNome
        private string _nome = "";
        private double _preco;
        private int _quantidade;


        public Produto(){}


        public Produto(string nome, double preco) : this()
        {
            this._nome = nome;
            this._preco = preco;

        }


        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            this._quantidade = quantidade;
        }

        public string GetNome()
        {
            return this._nome;
        }

        // se eu não quiser que um método seja alterado basta nào implementar
        // o método que irá alterar ele.
        public void SetNome(string nome)
        {

            if (nome != this._nome && nome.Length > 1)
            {
                this._nome = nome;
            }

        }

        public double GetPreco(){
            return this._preco;
        }

        public double GetQuantidade(){
            return this._quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return this._preco * this._quantidade;
        }

        //oq vamos aprender aqui é sobreposiçào que será explicado melhora mais para frente
        // do curso usando a palavra override
        public override string ToString()
        {   // o base é referido a nossa classe Produto ou qualquer
            // outra classe que fizermos isso. 
            return _nome
            + ", "
            + "$ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " Uninades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AddProdutoQuantidade(int addQuant)
        {
            this._quantidade += addQuant;
        }
        public void RemoveProduto(int rmQuant)
        {
            this._quantidade -= rmQuant;
        }
    }
}