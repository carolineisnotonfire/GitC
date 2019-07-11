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
            ListarCarros();
            TeladeInicio();
            if (MenudeOpcoes() == 1)
            {
                MostrarMenuAluguel();
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
                Console.WriteLine("\r\n Menu de escolhas: ");
                Console.WriteLine("\n 1 - Alugar um carro");
                Console.WriteLine("\n 2 - Sair do Sistema");
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
        public static void AlugarCarro(string nomedocarro)
        {
            for (int i = 0; i < bancodeCarros.GetLength(0); i++)
            {
                if (nomedocarro == bancodeCarros[i, 0])
                    bancodeCarros[i, 2] = "Indisponível para locação";
            }
        }
        public static void MostrarMenuAluguel()
        {
            Console.Clear();
            TeladeInicio();
            Console.WriteLine("Digite o carro a ser escolhido: ");
            var nomedocarro = Console.ReadLine();
            if (PesquisaCarrosDisponiveis(nomedocarro))
            {
                Console.Clear();
                Console.WriteLine("Você desejar alugar este carro? Sim (Y) Não (N)");
                if (Console.ReadKey().KeyChar.ToString() == "Y")
                {
                    AlugarCarro(nomedocarro);
                    Console.Clear();
                    Console.WriteLine("Carro alugado com sucesso!");
                }
                else
                Console.Clear();
                Console.WriteLine("Carros: ");
                for (int i = 0; i < bancodeCarros.GetLength(0); i++)
                {
                    Console.WriteLine($"Carro: {bancodeCarros[i, 0]} Ano: {bancodeCarros[i, 1]} Disponibilidade: {bancodeCarros[i, 2]}");
                }
            }
        }
    }
}
