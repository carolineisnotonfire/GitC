using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinha
{
    public class AquiMostraJoinha
    {
        public void MetodoInicial()
        {
            Console.WriteLine("Inicial pro joinha");


        }
        public void MetodoNovo(bool eQuinta)
        {
            if (eQuinta)

                Console.WriteLine("AAAAAAAAAAAA");
            else
                Console.WriteLine("aa");

        }
        public string[] TesteUmOperador()
        {
            return new string[2] { "t1", "t2" };
        }
    }
}
