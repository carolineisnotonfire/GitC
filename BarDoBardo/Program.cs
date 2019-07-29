using BarDoBardo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarDoBardo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Acoes> minhaLista = new List<Acoes>();
            for (int i = 0; i < 3; i++)
            {
                minhaLista.Add(new Acoes()
                {
                    Nome = RetornaValores("Nome"),
                    Quantidade = int.Parse(RetornaValores("Quantidade")),
                    Valor = double.Parse(RetornaValores("Valor"))
                });
            }

            foreach (Acoes item in minhaLista)
            {
                Console.WriteLine($"Lanches disponíveis: {item.Nome} Preço: {item.Valor}" +
                    $" Quantidade disponível: {item.Quantidade}");
                Console.ReadKey();
            }
        }
        public static string RetornaValores(string nome)
        {
            Console.WriteLine($"Informe o valor para o campo: {nome}");
            return Console.ReadLine();
        }
    }
}
