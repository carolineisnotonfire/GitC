using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aplicação final da biblioteca. 
            string[,] listaLivros = new string[2, 5];
            int IDLista = 0;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            var escolhaInicial = MenuInicial();
            while (true)
            {
                switch (escolhaInicial)
                {

                    case "1": { InsereRegistro(ref listaLivros, ref IDLista); } break;
                    case "2": { DeletarRegistros(ref listaLivros); } break;
                    case "3": { MostrarInformacoes(listaLivros); } break;
                    case "4": { MostrarInformacoes(listaLivros, "true"); } break;
                    case "5": { return; };
                }
                escolhaInicial = MenuInicial();
            }
        }
        /// <summary>
        /// simples método para mostrar uma tela mais esteticamente agradável
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("      Biblioteca Online ");
            Console.WriteLine("______________________________");
            Console.WriteLine("Seja bem-vindo(a) à biblioteca!");
            Console.WriteLine("______________________________");

        }
        /// <summary>
        /// Método com o menu inicial para todas as atividades que serão realizadas pelo usuário.
        /// </summary>
        /// <returns>Retorna o valor escolhido.</returns>
        public static string MenuInicial()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu Inicial");
            Console.WriteLine("1 - Inserir novo registro.");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("4 - Listar informações removidas.");
            Console.WriteLine("5 - Sair do sistema");

            Console.WriteLine("Digite a opção desejada: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Simples método para inserir registros de livros no sistema.
        /// Ele basicamente pega o nome do livro e o autor registrados pelo
        /// usuário e os transforma em variável, que posteriormente será
        /// utilizado para gravar as informações no sistema.
        /// </summary>
        /// <param name="listaLivros">O parâmetro listaLivros usado para referenciar nossa lista de livros. </param>
        /// <param name="IDLista">A referência externa de ID. </param>
        public static void InsereRegistro(ref string[,] listaLivros, ref int IDLista)
        {
            Console.Clear();
            Console.WriteLine("Nome do livro: ");
            var nomedolivro = Console.ReadLine();
            Console.WriteLine("Autor: ");
            var autordolivro = Console.ReadLine();
            AumentarTamanho(ref listaLivros);
            for (int i = 0; i < listaLivros.GetLength(0); i++)
            {
                if (listaLivros[i, 0] != null)
                    continue;

                listaLivros[i, 0] = (IDLista++).ToString();
                listaLivros[i, 1] = nomedolivro;
                listaLivros[i, 2] = autordolivro;
                listaLivros[i, 3] = "true";
                listaLivros[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                break;
            }

            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadKey();
        }
        /// <summary>
        /// Método para deletar os registros de livros anteriormente inseridos. 
        /// </summary>
        /// <param name="listaLivros">Referência à nossa lsita de livros com pelo menos um livro já inserido (ou pelo menos
        /// é o que se espera).</param>
        public static void DeletarRegistros(ref string[,] listaLivros)
        {
            Console.Clear();

            for (int i = 0; i < listaLivros.GetLength(0); i++)
            {
                Console.WriteLine($"ID: {listaLivros[i, 0] } Nome do livro: {listaLivros[i, 1]} Autor: {listaLivros[i, 2]} ");
            }
            Console.WriteLine("ID de registro a ser removido: ");
            var id = Console.ReadLine();

            for (int i = 0; i < listaLivros.GetLength(0); i++)
            {
                if (listaLivros[i, 0] == id)
                {
                    listaLivros[i, 3] = "false";
                    listaLivros[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }

            Console.WriteLine("Registro deletado!");
            Console.WriteLine("Para retornar ao menu inicial, aperte qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Método que mostra as informações dos registros, sendo eles
        /// deletados ou não. 
        /// </summary>
        /// <param name="listaLivros">Referência da lista de livros</param>
        /// <param name="mostrarRegistrosNAtivos">Lista os registros deletados (se houverem), caso não
        /// houver, ele fala que não há.</param>
        public static void MostrarInformacoes(string[,] listaLivros, string mostrarRegistrosNAtivos = "false")
        {
            Console.Clear();
            Console.WriteLine("Lista de livros: ");

            if (mostrarRegistrosNAtivos == "true")
                Console.WriteLine("Registros desativados dentro do sistema.");

            for (int i = 0; i < listaLivros.GetLength(0); i++)
            {
                if (listaLivros[i, 3] != mostrarRegistrosNAtivos)
                    Console.WriteLine($"ID {listaLivros[i, 0]} " +
                          $"- Nome do livro:{listaLivros[i, 1]} " +
                          $"- Autor:{listaLivros[i, 2]}" +
                          $"- Data Alteração:{listaLivros[i, 4]}");
            }

            Console.WriteLine("Para voltar ao menu inicial, aperte qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Aumenta o tamanho da nossa lista caso
        /// quisermos registrar mais livros.
        /// </summary>
        /// <param name="listaLivros">O parâmetro do listaLivros usado para aumentar a lista.</param>
        public static void AumentarTamanho(ref string[,] listaLivros)
        {
            var limiteLista = true;
            for (int i = 0; i < listaLivros.GetLength(0); i++)
            {
                if (listaLivros[i, 0] == null)
                    limiteLista = false;
            }
            if (limiteLista)
            {
                var listaCopia = listaLivros;
                listaLivros = new string[listaLivros.GetLength(0) + 2, 5];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    listaLivros[i, 0] = listaCopia[i, 0];
                    listaLivros[i, 1] = listaCopia[i, 1];
                    listaLivros[i, 2] = listaCopia[i, 2];
                    listaLivros[i, 3] = listaCopia[i, 3];
                    listaLivros[i, 4] = listaCopia[i, 4];
                }

                Console.WriteLine("Tamanho da lista atualizado!");
            }

        }
    }
}
