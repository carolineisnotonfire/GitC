using System;
namespace SistemaBibliotecaOnline
{
    class Program
    {
        static string[,] baseDeLivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();
            var opcaoMenu = Opcoes();
            while (opcaoMenu != 3)
            {
                opcaoMenu = Opcoes();
                if (opcaoMenu == 1)
                    AlocarUmLivro();

                if (opcaoMenu == 2)
                {
                    DesalocarUmLivro();
                }
                opcaoMenu = Opcoes();
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
            Console.Clear();

            MostrarSeja();

            Console.WriteLine("Menu - Inicial ");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar livro.");
            Console.WriteLine("2 - Devolver livro.");
            Console.WriteLine("3 - Sair do sistema.");
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
        /// Método para alterar a informação de alocação de livro.
        /// </summary>
        /// <param name="nomedolivro">nome do livro</param>
        /// <param name="alocar">valor boolean definindo se o livro está disponível ou não</param>
        public static void AlocarLivro(string nomedolivro, bool alocar)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomedolivro == baseDeLivros[i, 0])
                {
                    baseDeLivros[i, 1] = alocar? "não" : "sim";
                }
            }

            Console.Clear();

            MostrarSeja();

            Console.WriteLine("Livro atualizado com sucesso!");
        }
        public static void AlocarUmLivro()
            {
                MostrarMenuInicialLivros("Alocar um livro: ");
                var nomedolivro = Console.ReadLine();
                if (PesquisaLivroParaAlocacao(nomedolivro))
                {
                    Console.WriteLine("Deseja alocar o livro? Sim (y) Não (n)");

                    AlocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "y");
                    MostrarLista();

                    Console.ReadKey();
                }
            }
        /// <summary>
        /// Método que mostra a lista de livros atualizado.s
        /// </summary>
        public static void MostrarLista()
        {
            Console.WriteLine("Listagem de livros: ");
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeLivros[i, 0]}  Disponível: {baseDeLivros[i, 1]}");
            }
        }
        public static void DesalocarUmLivro()
        {
            MostrarMenuInicialLivros("Desalocar um livro: ");
            MostrarLista();
            var nomedolivro = Console.ReadLine();
            if (!PesquisaLivroParaAlocacao(nomedolivro))
            {
                Console.WriteLine("Deseja desalocar o livro? Sim (y) Não (n)");

                AlocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "n");
                MostrarLista();

                Console.ReadKey();
            }
        }
        public static void MostrarMenuInicialLivros(string operacao)
        {
            Console.Clear();

            MostrarSeja();

            Console.WriteLine($"Menu {operacao}");
            Console.WriteLine("Digite o nome do livro para realizar a operação: ");
        }
    }
}