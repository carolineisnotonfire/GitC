using SistemaCantina.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantina
{
    class Program
    {

       static Merenda mer;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            mer = new Merenda();
            Console.WriteLine($"Saldo atual disponível: R$ {mer.MostrarSaldo()}");
            MenuCompras();
            Console.WriteLine("Deseja comprar outro lanche? Sim (y) Não (aperte qualquer outra tecla)");
            var comprarnovamente = Console.ReadLine();
            while (comprarnovamente.ToString() == "y" )
            
                MenuCompras();
            
            Console.ReadKey();
        }
        public static void MenuCompras()
        {
           

            Console.WriteLine("Informe o lanche a ser comprado: ");
            var lanche2 = Console.ReadLine();
            Console.WriteLine("Informe o preço: ");
            double.TryParse(Console.ReadLine(), out double valorLanche);
            if (valorLanche > 0 && mer.ComprarLanche(valorLanche))
                Console.WriteLine("Compra realizada com sucesso.");
            else
                Console.WriteLine("Operação não realizada");
            Console.WriteLine($"Lanche: {lanche2} Preço: {valorLanche}");
            Console.WriteLine($"Saldo atual disponível: R$ {mer.MostrarSaldo()}");
        }
    }
}
