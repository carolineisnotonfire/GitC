using BancoCSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta accountUser = new Conta();
            Console.WriteLine($"Saldo atual disponível: R$ {accountUser.MostrarSaldo()},00");
            Console.WriteLine("Valor de saque: ");
            double.TryParse(Console.ReadLine(), out double valorSacar);
            //verifica se o valor é maior que 0 e se o saque foi realizado.
            if (valorSacar > 0 && accountUser.Sacar(valorSacar))
                Console.WriteLine("Saque realizado com sucesso.");
            else
                Console.WriteLine("Operação não realizada");


            Console.WriteLine($"Saldo atual disponível: R$ {accountUser.MostrarSaldo()},00");
            Console.WriteLine("Valor de depósito: ");
            double.TryParse(Console.ReadLine(), out double valorDepositar);
            if (valorDepositar > 0 && accountUser.Depositar(valorDepositar))
                Console.WriteLine("Depósito realizado com sucesso.");
            else
                Console.WriteLine("Operação não realizada");
            Console.WriteLine($"Saldo atual disponível: R$ {accountUser.MostrarSaldo()},00");


            Console.ReadKey();
        }
    }
}
