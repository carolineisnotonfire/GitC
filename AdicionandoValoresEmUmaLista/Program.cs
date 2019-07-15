using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionandoValoresEmUmaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeNome = new string[5, 2];
            int IDLista = 0;

            InsereRegistro(ref listaDeNome, ref IDLista);

            Console.ReadKey();

            InsereRegistro(ref listaDeNome, ref IDLista);

        }
        public static void InsereRegistro(ref string[,] listaDeNome, ref int IDLista)
        {
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                if (listaDeNome[i,0] != null)   
                
                    continue;
                
                Console.Clear();
                Console.WriteLine("Nome: ");
                var nome = Console.ReadLine();

                listaDeNome[i, 0] = (IDLista++).ToString();
                listaDeNome[i, 1] = nome;

                Console.WriteLine("Deseja inserir novo registro? SIM (Y) NÃO (N)");
                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "N")
                
                    break;
                
                AumentaTamanho(ref listaDeNome);

            }

            Console.WriteLine("Registro adicionado com sucesso!");

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {

                Console.WriteLine(string.Format("Registro ID - {0} Nome - {1}", listaDeNome[i, 0], listaDeNome[i, 1]));
            }
        }
        public static void AumentaTamanho(ref string [,] listaDeNome)
        {
            var limiteLista = true;

            for (int i = 0; i <listaDeNome.GetLength(0); i++)
            {
                if (listaDeNome[i,0] == null)
                {
                    limiteLista = false;
                }
            }

            if (limiteLista)
            {
                var listaCopia = listaDeNome;

                listaDeNome = new string[listaDeNome.GetLength(0) + 5, 2];


                for (int i = 0; i <listaCopia.GetLength(0); i++)
                {
                    listaDeNome[i, 0] = listaCopia[i, 0];
                    listaDeNome[i, 1] = listaCopia[i, 1];
                }

                Console.WriteLine("Tamanho da lista atualizado");
            }
        }

    }
}

