using System.Globalization;

namespace Course
{

    class Produto
    {


        // OBS: au Auto-Properties só funcionam em atributos que não tenham uma validação
        // ou bloco de código assim como o Atributo nome abaixo
        private string _nome = "";
        // usando essa opçào usamos as Auto-Properties para cada atributo da calsse
        // implementamos os métodos GetQuantidade e GetPreco dessa forma
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {

        }


        public Produto(string nome, double preco) : this()
        {
            this._nome = nome;
            Preco = preco;

        }


        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            this.Quantidade = quantidade;
        }

        // é equivalenta aos métodos GetNome e SetNome que criamos porem
        // seguindo o padrão do C# referencia desses métodos na aulad e (05-encapsulamento)

        // OBS: isso aqui nós chamamos de properties no C#
        public string Nome
        {
            get { return this._nome; }
            set
            {
                if (value != this._nome && value.Length > 1)
                {
                    this._nome = value;
                }
            }
        }


        public double ValorTotalEmEstoque()
        {
            return this.Preco * this.Quantidade;
        }

        //oq vamos aprender aqui é sobreposiçào que será explicado melhora mais para frente
        // do curso usando a palavra override
        public override string ToString()
        {   // o base é referido a nossa classe Produto ou qualquer
            // outra classe que fizermos isso. 
            return _nome
            + ", "
            + "$ "
            + this.Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + this.Quantidade
            + " Uninades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AddProdutoQuantidade(int addQuant)
        {
            this.Quantidade += addQuant;
        }
        public void RemoveProduto(int rmQuant)
        {
            this.Quantidade -= rmQuant;
        }
    }
}