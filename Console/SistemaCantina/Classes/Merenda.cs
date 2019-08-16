using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantina.Classes
{
    class Merenda
    {
        double saldo = 0;
        public double Saldo { get { return saldo; } set { saldo = value; } }
        public Merenda()
        {
            saldo = 20;
        }

        public bool ComprarLanche(double valor)
        {
            if (valor <= saldo)
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
    }
}
