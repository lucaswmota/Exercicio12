using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o Salario Fixo: R$");
            double salarioFixo = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de peças vendidas: ");
            int pecasVendidas = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor de comissão por peça: R$");
            double comissaoPeca = double.Parse(Console.ReadLine());

            Console.Write("Informe a Kilometragem percorrida: ");
            double kmPercorrido = double.Parse(Console.ReadLine());

            Console.Write("Informe o Valor por KM percorrido: R$");
            double valorKm = double.Parse(Console.ReadLine());

            double salarioFinal = salarioFixo + (pecasVendidas * comissaoPeca) + (kmPercorrido * valorKm);

            Console.WriteLine("\n\nSalario Final do Vendedor: R$" + salarioFinal);

            Console.ReadKey();
        }
    }
}
