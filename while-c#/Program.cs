using System.Globalization;

namespace Course{

    class Program{

        static void Main(string[] args){

            float number = 1;
            while(number >= 0){
                Console.WriteLine("Digite um Número:");
                float inputNumber = float.Parse(
                    Console.ReadLine(),
                    CultureInfo.InvariantCulture
                );

                if(inputNumber < 0){
                    Console.WriteLine("Número negativo");
                    number = inputNumber;
                }
                else{
                    Console.WriteLine($"{Math.Sqrt(inputNumber):F3}");
                }
            }
        }
    }
}