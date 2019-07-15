using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparação_de_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor inicial: ");
            var primeiroValor = Console.ReadLine();

            Console.WriteLine("Informe o valor secundário: ");
            var segundoValor = Console.ReadLine();

            if (primeiroValor == segundoValor)
            {
                Console.WriteLine("primeiro igual ao segundo");
            }

        }
    }
}
