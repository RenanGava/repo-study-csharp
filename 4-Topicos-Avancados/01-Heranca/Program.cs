using Course.Entities;

namespace Course
{


    class Program
    {

        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Renan", 4000, 20000);

            Console.WriteLine(account.Balance);
        }
    }
}