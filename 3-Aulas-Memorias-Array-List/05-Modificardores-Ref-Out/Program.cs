namespace Course
{

    class Program
    {

        static void Main(string[] args)
        {

            /* Operador Ref*/
            int a = 10;
            // como o método possui ref na tipagem do seu dado
            // pecisamos passar o ref para mostrarmos que ela sera uma referencia
            // e o valor que for o resultado da função sera repassado para a variavel 'a'
            Calculator.Triple(ref a);
            Console.WriteLine("Utilizando operador Ref: " + a);


            /* Operador Out*/
            int b = 3;
            int result;
            // utilizando o operador "ref" passamos a variavel referencia
            // e passando o operador "out" passamos o operador de saída ou resultado
            // pode ser feito assim com o ref no "b"
            Calculator.Triple(ref b, out result);
            Console.WriteLine("Utilizando operador Out: " + result);



            // OBS: varivel passada como parametro "ref" tem que ter recebido um valor
            // enquanto a variavel passada para o out não precisa.
        }
    }
}