using System;


namespace Name
{
    class Salario
    {
        public string name = "";
        public double salario;
        public double imposto = 0.1666;
        private double salLiquido;
        public string SalarioLiq()
        {
            salLiquido = salario - (Math.Ceiling(salario * imposto));

            return (
                name
                + ", SalarioLiqui: "
                + salLiquido.ToString("F2")
                + ", Salario Bruto: "
                + salario.ToString("F2")
                + ", imposto descontado"
                + imposto
            );
        }

        public string AumentarPorcentagemSalario(double aumentoPotcemtagem)
        {
            double calcAumento = salario * 0.1;
            salLiquido = calcAumento + (salario - (Math.Ceiling(salario * imposto)));

            return (
                name
                + ", SalarioLiqui: "
                + salLiquido.ToString("F2")
                + ", Salario Bruto: "
                + salario.ToString("F2")
                + ", imposto descontado"
                + imposto
            );
        }

    }
}