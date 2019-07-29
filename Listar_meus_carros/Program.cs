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
        static Carros carrosAdd;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            MenuInicial();
            switch (Console.ReadLine())
            {

                case "1": Inserir(carrosAdd); break;
                case "2": Listar(carrosAdd); break;
                case "3": { return; };
            }



            Console.ReadKey();

        }
        public static void MenuInicial()
        {
            Console.WriteLine("1 - Inserir veículo");
            Console.WriteLine("2 - Remove veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Sair do sistema");
        }
        public static string RetornaValores(string nome)
        {
            Console.WriteLine($"Informe o valor para o campo: {nome}");
            return Console.ReadLine();

        }
        public static void Inserir(Carros carrosAdd)
        {
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
        }

        public static void Listar(Carros carrosAdd)
        {
                foreach (Carros item in carrosAdd)
                {
                    Console.WriteLine($"Carro: {item.Modelo} Ano: {item.Ano} Placa: " +
                        $"{item.Placa} CV: {item.Cv}");
                }
        }

        
    }
}
