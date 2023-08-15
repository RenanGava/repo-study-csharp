using System;
namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario funcionario = new Salario();

            System.Console.Write("Digite o Nome do funcionário: ");
            funcionario.name = Console.ReadLine();

            System.Console.Write("Digite o Sálario do funcionário: ");
            funcionario.salario = double.Parse(Console.ReadLine());
            System.Console.WriteLine($"Funcionário: {funcionario.SalarioLiq()}");

            System.Console.Write("Digite o Aumento do Sálario em porcentamgem de 0 a 100: ");
            double aumento = double.Parse(Console.ReadLine());
            System.Console.WriteLine($"Funcionário: {funcionario.AumentarPorcentagemSalario(aumento)}");
        }
    }   
}