using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSuperCompacta.BibliotecaListaBi
{
    class ListaBi
    {
        string[,] listaBi;
        /// <summary>
        /// quando iniciamos uma instancia da lista bi ela ja vem com a lista carregada
        /// </summary>
        public ListaBi()
        {
            listaBi = new string[999999, 2];
            //ao chamar este metodo no construtor, nossa lista
            //ja vai estar carregada ao iniciar a instancia "jogar para memória"
            CarregaListaBi();
        }
        /// <summary>
        /// ja carregamos a lista quando chamamos este metodo
        /// </summary>
        public void CarregaListaBi()
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                listaBi[i, 0] = i.ToString();
                listaBi[i, 1] = $"Felipe_{i}";
                Console.WriteLine($"Id: {i} Nome: Felipe_{i}");
            }
        }
        public void PesquisaLista(string idPesquisa)
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                if (listaBi[i, 0] == idPesquisa)
                {
                    Console.WriteLine("Resultado encontrado com sucesso!");
                    Console.WriteLine($"Você pesquisou pelo registro: {listaBi[i,1]}");
                    //saindo do metodo pq n precisamos mais dele
                    return;
                }
            }
            Console.WriteLine("Nenhum registro encontrado com esse ID");
        }
    }
}
