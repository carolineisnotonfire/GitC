using BiblioCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("Insira a base: ");
            var bsRet = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura: ");
            var alturaRet = float.Parse(Console.ReadLine());
            Console.WriteLine(calc.AreaRetangulo(bsRet, alturaRet));
            Console.ReadKey();
        }
    }
}
