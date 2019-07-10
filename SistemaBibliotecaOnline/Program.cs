using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarSeja();

            if (Opcoes() == 1)
                Console.WriteLine("\r\nMenu - Alocação de livros ");


            Console.ReadKey();
        }

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
        
        
        
    }
}
