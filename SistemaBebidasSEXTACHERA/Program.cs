using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBebidasSEXTACHERA
{
    class Program
    {
        static void Main(string[] args)
        {
            BoasVindas();
            CompararIdade();
        }
        /// <summary>
        /// Um método de boas vindas. :D
        /// </summary>
        public static void BoasVindas()
        {
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("Bem-vindo ao sistema de bebidas alcoólicas!");
            Console.WriteLine("///////////////////////////////////////////");
        }
        /// <summary>
        /// Método basiquinho utilizado apenas para comparar se a pessoa que inserir seu nome é maior de 18.
        /// </summary>
        public static void CompararIdade()
        {
            Console.WriteLine("Nome: ");

            var nome = Console.ReadLine();

            Console.WriteLine("Idade: ");

            string line = Console.ReadLine();
            int idade = Convert.ToInt32(line);
            if (idade > 17)
            {
                Console.WriteLine($"Beleza, pó bebe, {nome}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"ih ala, não pode, {nome}");
                Console.ReadLine();
            }

        }
    }
}
