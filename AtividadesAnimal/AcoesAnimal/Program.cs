using AcoesAnimal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcoesAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal ani = new Animal();
            Console.WriteLine("TAMAGOTCHI BICHINHO VIRTUAL ^_^");
            Console.WriteLine("Deseja acordar seu Tamagotchi? Sim (s) Não (qualquer outra tecla)");
            var escolha1 = Console.ReadLine();
            if (escolha1 == "s")
            {
                Console.WriteLine("ACORDOU");
                Console.WriteLine(" .^._.^.");
                Console.WriteLine(" | . . |");
                Console.WriteLine(" (---  )");
                Console.WriteLine(" .'     '.");
                Console.WriteLine(" |/   | |");
                Console.WriteLine(" | / -| /");
                Console.WriteLine(" V    V");
                ani.Acordar();
            }
              //ALGUM DIA EU TERMINo  
            else
                Console.WriteLine("OK! Ele irá continuar dormindo! ZzZZZZZZzzzzZZzZZzZZ");
            Console.ReadKey();
        }
    }
}
