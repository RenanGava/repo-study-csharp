namespace Course.Entities
{


    class Account
    {

        public int Number { get; private set; }
        public string Holder { get; private set; }
        // utilizando o protected podemos mexer no atributo somente em classes
        // que estão herdando os atributos e métodos de outra classe
        // como a nossa classe BusinessAccount
        public double Balance { get; protected set; }



        public Account()
        {

        }
        public Account(int number, string holder, double balance)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
        }

        public void Withdraw(double amount)
        {
            this.Balance -= amount;
        }
        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
    }
}