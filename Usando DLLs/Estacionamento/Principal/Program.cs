using Principal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimeEstacionamento imp = new ImprimeEstacionamento();
            imp.inserir();
            imp.listar();

            Console.ReadKey();
        }
    }

}
