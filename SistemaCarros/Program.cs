using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SistemaCarros
{
    class Program
    {
        static string[,] bancodeCarros;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            ListarCarros();
            TeladeInicio();
            var opcaoMenu = MenudeOpcoes();
            while (opcaoMenu != 3)
            {
                if (MenudeOpcoes() == 1)
                    AlugarUmCarro();
                if (MenudeOpcoes() == 2)
                {
                    DevolverCarro();
                }
                opcaoMenu = MenudeOpcoes();
            }
            Console.ReadKey(); 
        }
        /// <summary>
        /// Método de boas vindas
        /// </summary>
        public static void TeladeInicio()
            {
                Console.WriteLine("Bem vindo a locadora Ambev! Seu fiat de firma lhe aguarda!");
                Console.WriteLine("___________________________________________________________");
                Console.WriteLine("            Desenvolvido pelas indústrias Volskaya");
                Console.WriteLine("___________________________________________________________");
            }
        /// <summary>
        /// Método do menu e de seu controle
        /// </summary>
        /// <returns>É pra retornar em inteiro</returns>
        public static int MenudeOpcoes()
            {
                Console.Clear();

                TeladeInicio();

                Console.WriteLine("Menu de escolhas: ");
                Console.WriteLine("\n 1 - Alugar um carro");
                Console.WriteLine("\n 2 - Devolver carro");
                Console.WriteLine("\n 3 - Sair do Sistema");
                Console.WriteLine("\n Digite o número: ");
                int.TryParse(Console.ReadKey().KeyChar.ToString(), out int escolha);
                return escolha;
            }
        public static void ListarCarros()
        {
            bancodeCarros = new string[4, 3]
            {
                {"Fiat UNO de firma", "2016", "Disponível para locação" },
                {"Peugeot Citroen de motorista UBER", "2009", "Disponível para locação" },
                {"Chevrolet Celta", "2004", "Indisponível para locação" },
                {"Honda Civic", "2018", "Indisponível para locação" }
            };
        }
        public static bool PesquisaCarrosDisponiveis(string nomedocarro)
        {
            for (int i = 0; i < bancodeCarros.GetLength(0); i++)
            {
                if (nomedocarro == bancodeCarros[i, 0])
                {
                    Console.WriteLine($"{nomedocarro} do ano de {bancodeCarros[i, 1]} \r Disponibilidade:{bancodeCarros[i, 2]} \n");
                    return bancodeCarros[i, 2] == "Disponível para locação";
                }
            }
            return false;
        }
        public static void AlugarCarro(string nomedocarro, bool alocar)
        {
            for (int i = 0; i < bancodeCarros.GetLength(0); i++)
            {
                if (nomedocarro == bancodeCarros[i, 0])
                    bancodeCarros[i, 2] = alocar? "Indisponível para locação" : "Disponível para locação";
            }
        }
        public static void AlugarUmCarro()
        {
            MostrarMenuInicialCarros("para alugar carro: ");
            MostrarLista();
            var nomedocarro = Console.ReadLine();
            if (PesquisaCarrosDisponiveis(nomedocarro))
            {
                Console.Clear();
                TeladeInicio();
                Console.WriteLine("Deseja alugar o carro? Sim (Y) Não (N)");

                AlugarCarro(nomedocarro, Console.ReadKey().KeyChar.ToString() == "Y");
                MostrarLista();
                

                
            }
            MostrarHora();
            Console.ReadKey();
        }
        public static void MostrarLista()
        {
            Console.Clear();
            Console.WriteLine("Carros/Ano/Disponibilidade:");
            for (int i = 0; i < bancodeCarros.GetLength(0); i++)
            {
                Console.WriteLine($"{bancodeCarros[i, 0]} Ano: {bancodeCarros[i, 1]} Disponibilidade: {bancodeCarros[i, 2]}");
            }
        }
        public static void DevolverCarro()
        {
            MostrarMenuInicialCarros("para devolver carro: ");
            MostrarLista();
            var nomedocarro = Console.ReadLine();
            if (!PesquisaCarrosDisponiveis(nomedocarro))
            {
                Console.WriteLine("Deseja devolver o carro? Sim (Y) Não (N)");

                AlugarCarro(nomedocarro, Console.ReadKey().KeyChar.ToString() == "N");
                Console.Clear();
                MostrarLista();
                MostrarHora();

                Console.ReadKey();
            }

        }
        public static void MostrarMenuInicialCarros(string operacao)
        {
            Console.Clear();

            TeladeInicio();

            Console.WriteLine($"Menu {operacao}");
            Console.WriteLine("Digite o nome do carro: ");
        }
        public static void MostrarHora ()
        {
            string horario = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            Console.WriteLine("Horário: " + horario);
        }
    }
}
