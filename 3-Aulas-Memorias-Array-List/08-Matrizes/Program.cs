using System.Collections.Generic;

namespace Course
{


    class Program
    {

        static void Main(string[] args)
        {
            // abrir e fechar colchetes com uma virgula dentro simboliza um 
            // array bidimensional ou uma "Matriz"

            // OBS: o 2, 3 é o mesmo que a quantidade de linhas e colunas
            // nessa respectiva ordem
            double[,] mat = new double[2, 3];

            // pega a quantidade total de objetos dentro da matriz
            System.Console.WriteLine(mat.Length);

            // pega a quantidade de linhas da matriz
            System.Console.WriteLine(mat.Rank);


            // podemos pegar o comprimento de cada linha da matris dessa forma.
            System.Console.WriteLine(mat.GetLength(0));

            System.Console.WriteLine(mat.GetLength(1));
        }

    }
}