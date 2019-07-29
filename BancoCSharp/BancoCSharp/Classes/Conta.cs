using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCSharp.Classes
{
    public class Conta
    {
        double saldo = 0;
        public double Saldo { get { return saldo; } }

        public Conta()
        { 
            //Bonus de mil reais pra iniciar operaações daytrade
            saldo = 1000;
        }
        /// <summary>
        /// Método para sacar dinheiro de acordo com o saldo disponível
        /// </summary>
        /// <param name="valor">valor a ser sacado.</param>
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            //desconta do valor em saldo na conta
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        public double MostrarSaldo()
        {
            return saldo;
        }
        public bool Depositar(double valordep)
        {
            if (valordep == null)
            {
                return false;
            }
            saldo += valordep;
            return true;
        }
    }
}
