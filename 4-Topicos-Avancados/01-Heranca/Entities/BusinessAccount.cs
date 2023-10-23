namespace Course.Entities
{


    // Para extendermos uma classe no C# basta utilizar como abaixo
    // utilizamos herança para isso funcionar
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        // utilizando o comando base aproveitamos o construtor da classe que herdamos "Account"
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            this.LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {

            if (amount <= this.LoanLimit)
            {
                this.Balance += amount;
            }
        }
    }
}