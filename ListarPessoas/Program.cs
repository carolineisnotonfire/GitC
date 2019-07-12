using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarPessoas
{
    class Program
    {
        static string[,] listarPessoas;
        static void Main(string[] args)
        {
            CarregaAlunos();
            Listar();
            Console.ReadKey();
        }
        /// <summary>
        /// Esse método carrega uma lista de alunos com sua idade e sexo (considerando que é um curso sem restrição de idade)
        /// </summary>
        public static void CarregaAlunos()
        {
            listarPessoas = new string[20, 3]
                {{"Louis  Park", "14", "M" }, {"Harriet Bradley", "54", "F"},
                {"Ronnie  Valdez", "17", "M" }, {"Raymond Perry", "15", "M" },
                {"Ivan Pope", "24", "M" }, {"Edwin Duncan", "21", "M"},
                {"Angel Simon", "26", "F" }, {"Nelson Poole", "24", "M"},
                {"Barbara Tyler", "22", "F" }, {"Kelly Payne", "51", "F" },
                {"Sandra Thomas", "32", "F" }, {"Leona Fleming", "56", "F" },
                {"Roy Garcia", "12", "M" }, {"Jasmine Hall", "36", "F" },
                {"Ann Black", "33", "F" }, {"Martha Bates", "35", "F" },
                {"Kathleen Schmidt", "67", "F" },  {"Drew Lawson", "18", "M" },
                {"Caroline Swanson", "52", "F" }, {"Rebecca Cook", "42", "F" }};
            
        }
        /// <summary>
        /// Lê a lista de pessoas e posiciona seus dados.
        /// </summary>
        public static void Listar()
        {
            for (int i = 0; i < listarPessoas.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {listarPessoas[i, 0]} Idade: {listarPessoas[i, 1]} Sexo: {listarPessoas[i, 2]}");
            }
            Console.ReadKey();
        }
    }
}
