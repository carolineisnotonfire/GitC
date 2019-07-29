using Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizarCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacoes op = new Operacoes();
            Console.WriteLine("Digite a área: ");
            var valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(op.CalculaRaio(valor1));
            Console.ReadKey();
        }
    }
}
