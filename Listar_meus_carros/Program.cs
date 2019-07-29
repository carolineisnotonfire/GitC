using Listar_meus_carros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_meus_carros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carros> carrosAdd = new List<Carros>();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                carrosAdd.Add(new Carros()
                {
                    Modelo = RetornaValores("Modelo"),
                    Ano = int.Parse(RetornaValores("Ano")),
                    Placa = RetornaValores("Placa"),
                    Cv = int.Parse(RetornaValores("CV"))
                });
            }

            foreach (Carros item in carrosAdd)
            {
                Console.WriteLine($"Carro: {item.Modelo} Ano: {item.Ano} Placa: " +
                    $"{item.Placa} CV: {item.Cv}");
            }
            Console.ReadKey();

        }
        public static string RetornaValores(string nome)
        {
            Console.WriteLine($"Informe o valor para o campo: {nome}");
            return Console.ReadLine();
        }
    }
}
