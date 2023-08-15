namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis numéricas
            SByte n0 = 100; // esse tipo aceita valores entre -128 até 127
            Byte n1 = 126; // não aceita sinal e pode receber valores entre 0 e 255
            int n2 = 2147483647; // aceita valores entre -2³¹ e 2³¹
            long n3 = 2147483648L; // aceita valores muito maiores que o tipo "int"
            // esse tipo pode colocar o "L" no final para simbolizar o tipo "long"
            Double n4 = 12.33; // aceita valores com 2 casas decimais depois da ","
            decimal n5 = 10.21234M; // aceita valores com até 28 casas decimas depois da ","
            float n6 = 4.5f; // valores do tipo float devem receber o sufixo 'F' no final

            // variavel booleana
            Boolean varBoleana = false; // essse tipo aceita valores verdadeiro ou falsos

            // variavel de caracteres Unicode.
            char caracter = 'M'; // aceita apenas 1 caracter e tendo com aspas simples -> ''

            // tipos de referencia OBS: São imutáveis
            string nome = "Renan"; // tem que ser dentro de aspas duplas a string.
            object obj1 = "Laura"; // pode assumir qualquer outros valores genéricos de objetos

            Console.WriteLine("Variaveis numéricas!");
            Console.WriteLine(n0);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine("---------------------");
            Console.WriteLine("Variaveis Booleanas!");
            Console.WriteLine(varBoleana);
            Console.WriteLine("---------------------");
            Console.WriteLine("variaveis Booleanas!");
            Console.WriteLine(caracter);
            Console.WriteLine("---------------------");
            Console.WriteLine("variaveis String!");
            Console.WriteLine(nome);
            Console.WriteLine("---------------------");
            Console.WriteLine("Tipos de objeto");
            Console.WriteLine(obj1);
        }
    }
}