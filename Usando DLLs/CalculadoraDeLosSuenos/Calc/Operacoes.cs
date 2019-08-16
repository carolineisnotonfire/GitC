using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Operacoes
    {
        public double CalculaAdicao(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public double CalculaSubtracao(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
        public double CalculaMultiplicacao(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
        public double CalculaDivisao(double valor1, double valor2)
        {
            return valor1 / valor2;
        }

        public double CalculaRet(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public double CalculaTriEq(double valor1, double valor2)
        {
            return (valor1 * valor2) / 2;
        }

        public double CalculaRaio(double valor1)
        {
            return (Math.Sqrt(valor1 / Math.PI));
        }
    }
}
