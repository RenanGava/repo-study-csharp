namespace Name{


    class Calculadora {
        
        public double PI = Math.PI;
        
        public double CalcCircunferencia(double raio)
        {
            return 2.0 * PI * raio;
        }

        public double CalcVolume(double raio)
        {
            return 4 / 3 * PI * Math.Pow(raio, 3);
        }
    }
}