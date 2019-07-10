using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaBibliotecaOnline
{
    class Program
    {
        static string[,] baseDeLivros;

        static void Main(string[] args)
        {
            CarregaBaseDeDados();
            MostrarSeja();
            if (Opcoes() == 1)
            {
                Console.Clear();
                MostrarSeja();
                Console.WriteLine("Menu - Alocação de livros ");
                Console.WriteLine("Digite o nome do livro a ser alocado: ");
                var nomedolivro = Console.ReadLine();
                if (PesquisaLivroParaAlocacao(nomedolivro))
                {
                    Console.WriteLine("Deseja alocar o livro? Sim (y) Não (n)");
                    if (Console.ReadKey().KeyChar.ToString() == "y")
                        {
                        AlocarLivro(nomedolivro);
                        }
                    Console.Clear();
                    Console.WriteLine("Livro Alocado!");
                    Console.WriteLine("Listagem de livros: ");

                    for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                        {
                        Console.WriteLine($"Nome: {baseDeLivros[i, 0]}  Disponível: {baseDeLivros[i, 1]}");
                        }
                    {

                    }

                }

            }
            Console.ReadKey();
        }
        /// <summary>
        /// Método que mostra uma mensagem de boas vindas.
        /// </summary>
        public static void MostrarSeja()
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("Seja bem vindo ao sistema" +
                $" de alocação de livros.");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("AAAAAAAAAAAAAAAAAA\n\n");

        }
        /// <summary>
        /// Método que mostra o conteúdo do menu e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um  tipo inteiro.</returns>
        public static int Opcoes()
        {
            Console.WriteLine("\r\nMenu - Inicial ");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar livro.");
            Console.WriteLine("2 - Sair do sistema");
            Console.WriteLine("Digite o número desejado: ");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            return opcao;

        }
        /// <summary>
        /// Método que carrega a base de dados do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                { "O pequeno", "Disponível para locação"},
                { "O grande", "Indisponível para locação"} 
            };
        }
        /// <summary>
        /// Método que retorna se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomedolivro">Nome do livro a ser pesquisado </param>
        /// <returns>Retorna verdadeiro caso o livro estiver disponível para alocação</returns>
        /// 
        public static bool PesquisaLivroParaAlocacao(string nomedolivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomedolivro == baseDeLivros[i, 0])
                {
                    Console.WriteLine($"Status do livro: {baseDeLivros[i, 1]}");

                    return baseDeLivros[i, 1] == "Disponível para locação";

                }
            }
            return false;
        }
        /// <summary>
        /// Método que aloca o livro de acordo com o parametro passado.
        /// </summary>
        /// <param name="nomedolivro">Livro a ser alocado</param>
        public static void AlocarLivro(string nomedolivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomedolivro == baseDeLivros[i, 0])
                    baseDeLivros[i, 1] = "Indisponível";
            }
        }
    }
}