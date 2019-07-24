using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstExternalLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFiles teste = new GetFiles();
            var mydocs = teste.RetornaArquivosDoMeuDocumentos();
            for (int i = 0; i < mydocs.Length; i++)
            {
                Console.WriteLine(mydocs[i]);
            }

            var mygit = teste.RetornaArquivosGit();
            for (int i = 0; i < mygit.Length; i++)
            {
                Console.WriteLine(mygit[i]);
            }

            var mypics = teste.RetornaArquivosImagesFiles();
            for (int i = 0; i < mypics.Length; i++)
            {
                Console.WriteLine(mypics[i]);
            }
            Console.ReadKey();
        }
    }
}
