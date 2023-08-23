namespace Course
{

    class Calculator
    {

        // para corrigir facilitar a escrita para 
        // evitar de fircar escrevendo new int[] {1,2, ...}
        // quando vamos passar os valores para este método
        // basta colocar params antes do int[] no método
        // como feito abaixo
        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        /* Operador Ref*/
        // colocando o ref antes do tipo do dado
        // ele vai se tornar uma referencia para a variavel que foi passada para dentro dele
        public static void Triple(ref int x){

            x *= 3;
        }


        /* Operador Out*/
        public static void Triple(ref int origin, out int result){

            result = origin * 3;
        }
    }
}
