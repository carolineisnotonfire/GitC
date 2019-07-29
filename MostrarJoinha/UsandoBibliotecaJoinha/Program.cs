using MostrarJoinha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoBibliotecaJoinha
{
    class Program
    {
        static void Main(string[] args)
        {
            /*new AquiMostraJoinha().MetodoInicial();
            new AquiMostraJoinha().MetodoNovo(true);
            new AquiMostraJoinha().MetodoNovo(false);*/
            //operação pesada com leitura e gravação na memória...
            var outro = new AquiMostraJoinha().TesteUmOperador();
            var tamanhoDaLista = outro.Length;
            for (int i = 0; i < tamanhoDaLista; i++)
            {
                Console.WriteLine(outro[i]);

            }
            Console.ReadKey();
        }
    }
}
