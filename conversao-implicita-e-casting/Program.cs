namespace Course{

    class Program{
        static void Main(string[] args){
            float x1 = 4.5f;
            double y1 = x1; // conversào de forma implicita

            double a;
            int b1;

            a = 5.1;
            float b = (float)a; // conversão por casting
            b1 = ((int)a); // conversão por casting OBS: nesse caso tivemos perda de informação.

            Console.WriteLine(b);
            Console.WriteLine(b1);
        }
    }
}