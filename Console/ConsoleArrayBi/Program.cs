using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArrayBi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeLivros = new string[2, 2]
            {{ "Livro 1", "disponível" }, {"Livro 2", "não disponível" } };

            Console.WriteLine("Bem-vindo a biblioteca, " +
                $"a biblioteca mais usada! \n\nLivros disponíveis");

            

            for (int i = 0; i < listaDeLivros.GetLength(0); i++)
            {
                var livro = listaDeLivros[i, 0];
                var disponibilidade = listaDeLivros[i, 1];

                Console.WriteLine($"Livro: {livro} Disponibilidade: {disponibilidade}.");
            }
            Console.ReadKey();
           

            //Console.Write(livro[0, 0]);
            //Console.Write(livro[0, 1]);
            //
            //Console.WriteLine();
            //
            //Console.Write(livro[1, 0]);
            //Console.Write(livro[1, 1]);
            //
            //Console.WriteLine();
            //
            //Console.Write(livro[2, 0]);
            //Console.Write(livro[2, 1]);
            //
            //Console.WriteLine();
            //
            //Console.Write(livro[3, 0]);
            //Console.Write(livro[3, 1]);
            //
            //Console.WriteLine();
            //
            //Console.Write(livro[4, 0]);
            //Console.Write(livro[4, 1]);
            //
            //Console.WriteLine();
            //
            //Console.Read();
        }
    }
}
