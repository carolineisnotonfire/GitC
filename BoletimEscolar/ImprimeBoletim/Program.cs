using RecebeFrequencia.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImprimeBoletim
{
    class Program
    {
        static void Main(string[] args)
        {
            CriarEmArray input = new CriarEmArray();
            input.inserir();
            Console.Clear();
            input.listar();

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Informe registro que deseja excluir");
            int.TryParse(Console.ReadLine(), out int reg);

            input.alterar(reg);
            input.listar();
            Console.ReadKey();
        }
    }
}
