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
            string[,] listaMusica = new string[2, 3];
            int IDLista = 0;
            Console.WriteLine("Iniciando sistema de lista de nome e idade.");
            var escolhaInicial = MenuInicial();
            while (true)
            {
                switch (escolhaInicial)
                {
                    case "1": { InsereRegistro(ref listaMusica, ref IDLista); } break;
                    case "2": { Deleta(ref listaMusica); } break;
                    case "3": { MostrarInformacoes(listaMusica); } break;
                    case "4": { return; }
                }
                //Alimento a escolha novamente 
                escolhaInicial = ApresentaMenuInicial();
            }

        }
        public static void MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inseir um novo registro.");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("4 - Sair do sistema.");

            Console.WriteLine("Digite o número da opção desejada:");
            //retorna diretamente o menu escolhido.
            return Console.ReadLine();
        }
        public static void InsereRegistro(ref string[,] listaMusica, ref int IDLista)
        {
            Console.WriteLine("Álbum: ");
            var album = Console.ReadLine();
            Console.WriteLine("Ano: ");
            var ano = Console.ReadLine();
            AumentaTamanho(ref listaMusica);
            for (int i = 0; i < listaMusica.GetLength(0); i++)
            {
                if (listaMusica[i, 0] != null)
                    continue;

                listaMusica[i, 0] = (IDLista++).ToString();
                listaMusica[i, 1] = album;
                listaMusica[i, 2] = ano;
                break;
            }
            Console.WriteLine("Registro cadastrado!");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
            Console.ReadKey();
        }
        public static void Deleta(ref string[,] listaMusica)
        {

            for (int i = 0; i < listaMusica.GetLength(0); i++)
                Console.WriteLine($"ID: {listaMusica[i, 0]} Nome: {listaMusica[i, 1]} Idade {listaMusica[i, 2]}");

            Console.WriteLine("ID de registro a ser removido: ");
            var id = Console.ReadLine();

            for (int i = 0; i < listaMusica.GetLength(0); i++)
            {
                if (listaMusica[i, 0] == id)
                {
                    listaMusica[i, 0] = null;
                    listaMusica[i, 1] = null;
                    listaMusica[i, 2] = null;
                }
            }

            Console.WriteLine("Para retornar ao menu inicial, aperte qualquer tecla");
            Console.ReadKey();


        }
        public static void MostrarInformacoes(string[,] listaMusica)
        {
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
                if (listaMusica[i, 0] == null)
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

    }
}
