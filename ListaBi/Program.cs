using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBi
{
    class Program
    {
        static void Main(string[] args)
        {
            // lista bidimensional
            string[,] listaDeNome = new string[5, 2];
            CarregaInfoLista(ref listaDeNome);
            Console.WriteLine("ID de registro a ser pesquisado: ");
            PesquisaInfoLista( listaDeNome, Console.ReadLine());
            Console.ReadKey();
        }
        /// <summary>
        /// carrega informações iniciais da coleção
        /// </summary>
        public static void CarregaInfoLista(ref string[,] arrayBi)
        {
            //GetLength com parametro 0 indica que queremos o tamanho da primeira coluna
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                // carregando a "id"
                arrayBi[i, 0] = i.ToString();
                //informação extra
                arrayBi[i, 1] = $"askjnadjn_{i}";
            }

            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                Console.WriteLine($"ID: {arrayBi[i, 0]} - Nome: {arrayBi[i, 1]}");
            }
        }
        
        public static void PesquisaInfoLista(string [,] arrayBi, string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                if (arrayBi[i,0] == pId)
                {
                    Console.WriteLine($"Informação escolhida: ID: {arrayBi[i, 0]} Nome: {arrayBi[i, 1]}");
                    return;
                }
            }
            Console.WriteLine("Nenhum resultado encontrado");
        }

    }

}
