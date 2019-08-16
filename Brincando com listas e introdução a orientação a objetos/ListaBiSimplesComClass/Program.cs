using ListaBiSimplesComClass.Carrega;
using ListaBiSimplesComClass.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSimplesComClass
{
    class Program
    {
        static void Main(string[] args)
        {

            //inicia objeto em memória
            var carregaLista = new CarregarLista();

            carregaLista.CarregaInformacoesEListaElasEmTela();

            var mostrarLista = new MostrarLista();

            mostrarLista.PesquisandoInformacoesNaNossaLista(carregaLista.ListaNome,"0");

            Console.ReadKey();
        }
    }
}
