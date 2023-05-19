namespace Course{

    class Produto{

        public string Nome = "";
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }
    }
}