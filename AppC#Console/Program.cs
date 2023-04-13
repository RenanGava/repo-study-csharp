using System;

namespace MyApp
{
    class Testando
    {
        // Geralmente usado para identificar o Entrypoint da aplicação.
        // O Main
        static void Main(string[] args)
        {
            var ValorGas = 6.19;
            var ValoraEtnl = 5.19;

            double relacaoValorcombustivel = ValoraEtnl / ValorGas;

            if (relacaoValorcombustivel >= 0.70)
            {
                Console.WriteLine(relacaoValorcombustivel);
            }
            else if (relacaoValorcombustivel <= 0.70)
            {
                Console.WriteLine(relacaoValorcombustivel);
            }
            else
            {
                Console.WriteLine(relacaoValorcombustivel);
            }

            Console.WriteLine(args);
        }
    }
}