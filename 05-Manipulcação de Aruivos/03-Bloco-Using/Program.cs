namespace Course
{




    class Program
    {



        static void Main(string[] args)
        {


            string path = @"C:\Users\renan\Desktop\C#\05-Manipulcação de Aruivos\03-Bloco-Using\txt1.txt";

            // vamos utilizar o bloco using() e vamos instaciar
            // nossos métodos.
            try
            {

                // fazemos dessa forma para instanciarmos o stream reader
                // para utilizar precisamos passar o modulo de Filestream
                
                // OBS: podemos usar a forma resumida com o metodo File
                using (StreamReader sr = File.OpenText(path))
                {

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Arquivo Não Encontrado Encerrando Programa\n" + e);
            }
            finally
            {
                Console.WriteLine("Encerrado!");
            }
        }
    }
}
