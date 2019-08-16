using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
           var elementox = new Teste(5,5);
            elementox.MostrarInformacoes();
            elementox.AlterarInformacoes(5,5);
            elementox.MostrarInformacoes();
            MeninaSuperPoderosa(elementox);
            elementox.MostrarInformacoes();
            Console.ReadKey();
        }
        public static void MeninaSuperPoderosa(Teste pTeste)
        {
            pTeste.AlterarInformacoes();
            pTeste.MostrarInformacoes();
        }
    }
    public class Teste
    {
        private int A { get; set; } = 0;
        private int B { get; set; } = 0;
        public Teste(int pA, int pB)
        {
            A = pA;
            B = pB;
        }
        public void AlterarInformacoes()
        {
            A = B * 100;
        }
        public void AlterarInformacoes(int pA, int pB)
        {
            A = pA * 2;
            B = pB * 2;
        }
        public void MostrarInformacoes()
        {
            Console.WriteLine(A + B);
        }
    }
}
