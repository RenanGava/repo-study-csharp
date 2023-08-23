using System.Collections.Generic;

namespace Course
{


    class Program
    {

        static void Main(string[] args)
        {

            
            // para pegarmos o comprimento da lista
            // temos que usar o Count ao invés de Lenght
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Bob");
            list.Add("Renan");
            list.Add("Laura");
            list.Add("Rafael");
            list.Insert(2, "Adilson");


            foreach(var name in list){
                Console.WriteLine(name);
            }

            // podemos usar uma arrow function ou lambda
            string s1 = list.Find(x => x[0] == 'R');
            Console.WriteLine(s1);

            string s2 = list.FindLast(x => x[0] == 'R');
            Console.WriteLine(s2);

            Console.WriteLine("____________________________________________________");

            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach(var name in list2){
                Console.WriteLine(name);
            }
        }

    }
}