namespace Course
{

    public struct ObjNum_Menor_Maior{
        public int nMaior = 0;
        public int nMenor = 0;

        public ObjNum_Menor_Maior(int n_Maior, int n_Menor){
            nMaior = n_Maior;
            nMenor = n_Menor;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("digite um número");
            
            ObjNum_Menor_Maior num_Menor_Maior = new ObjNum_Menor_Maior();

            while (true)
            {
                int numero = int.Parse(Console.ReadLine());


                if (numero > num_Menor_Maior.nMaior)
                {
                    num_Menor_Maior.nMaior = numero;
                }
                else if (num_Menor_Maior.nMaior > numero)
                {
                    num_Menor_Maior.nMenor = numero;
                }
                
                string resultado = Compare(numero, num_Menor_Maior);
                Console.WriteLine(resultado);
            }
        }

        static string Compare(int numero, ObjNum_Menor_Maior numComparer){
            return $"numero: {numero}\n numeroMaior: {numComparer.nMaior} \n numeroMenor: {numComparer.nMenor}";
        }
    }
}