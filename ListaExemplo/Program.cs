using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista com tres valores um id e outras duas que o usuario coloque

            string[,] listaMusica = new string[5, 3];

            int IDLista = 0;

            InsereRegistro(ref listaMusica, ref IDLista);
            Deleta(ref listaMusica);

            Console.ReadKey();
        }
        public static void InsereRegistro (ref string [,] listaMusica, ref int IDLista)
        {
            for (int i = 0; i < listaMusica.GetLength(0); i++)
            {
                if (listaMusica[i, 0] != null)
                    continue;

                Console.WriteLine("Álbum: ");
                var album = Console.ReadLine();

                listaMusica[i, 0] = (IDLista++).ToString();
                listaMusica[i, 1] = album;

                Console.WriteLine("Ano: ");
                var ano = Console.ReadLine();

                listaMusica[i, 2] = ano;

                Console.WriteLine("Inserir novo registro? sim (y) não (n)");
                var continuar = Console.ReadKey().KeyChar.ToString();
                Console.Clear();
                if (continuar == "n")

                    break;
                AumentaTamanho(ref listaMusica);

            }

                Console.WriteLine("Lista de álbuns: ");

                for (int i = 0; i < listaMusica.GetLength(0); i++)

                    Console.WriteLine(string.Format("ID do Álbum: {0 } Álbum: {1} Ano: {2}", listaMusica[i, 0], listaMusica[i, 1], listaMusica[i, 2]));
                Console.ReadKey();

        }
        public static void AumentaTamanho(ref string[,] listaMusica)
        {
            var limiteLista = true;
            for (int i = 0; i < listaMusica.GetLength(0); i++)
            {
                if (listaMusica [i,0] == null)
                
                    limiteLista = false;
                

            }

            if (limiteLista)
            {
                var listaCopia = listaMusica;

                listaMusica = new string[listaMusica.GetLength(0) + 5, 3];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    listaMusica[i, 0] = listaCopia[i, 0];
                    listaMusica[i, 1] = listaCopia[i, 1];
                    listaMusica[i, 2] = listaCopia[i, 2];
                }

                Console.WriteLine("Tamanho da lista atualizado!");
            }
        }
        public static void Deleta(ref string[,] listaMusica)
        {
                Console.Write("Posição do item a ser deletado: ");
                var pos = Console.ReadLine();
                pos = string.Empty;            
                Console.WriteLine(pos);
                Console.WriteLine("Lista de álbuns: ");

                for (int i = 0; i < listaMusica.GetLength(0); i++)

                    Console.WriteLine(string.Format("ID do Álbum: {0 } Álbum: {1} Ano: {2}", listaMusica[i, 0], listaMusica[i, 1], listaMusica[i, 2]));
                    Console.ReadKey();

        }
    }
}
