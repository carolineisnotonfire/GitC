using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalc
{
    public class Calculadora
    {
        public static int CalculaAdicao(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        public static int CalculaSubtracao(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
        public static int CalculaMultiplicacao(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        public static int CalculaDivisao(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
    }
}
