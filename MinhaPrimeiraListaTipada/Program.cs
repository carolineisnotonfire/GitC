using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            //esse é o indicador <T>, o tipo da minha lista, com isso temos
            // a lista de lanches
            List<Lanche> minhaLista = new List<Lanche>();

            minhaLista.Add(new Lanche()
            {
                Nome = "Pão de Queijo",
                Quantidade = 9,
                Valor = 1.85
            });
            minhaLista.Add(new Lanche()
            {
                Nome = "Bolinho",
                Quantidade = 4,
                Valor = 3.98
            });
            minhaLista.Add(new Lanche()
            {
                Nome = "Empada",
                Quantidade = 19,
                Valor = 11.85
            });
            minhaLista.Add(new Lanche()
            {
                Nome = "Coxinha",
                Quantidade = 5,
                Valor = 5.85
            });
            minhaLista.Add(new Lanche()
            {
                Nome = "Espetinho",
                Quantidade = 14,
                Valor = 4.85
            });
            minhaLista.Add(new Lanche()
            {
                Nome = "Bauru",
                Quantidade = 6,
                Valor = 8.85
            });
            // andando pela minha lista para poder apresentar em tela os valores
            // o item in significa que ele já é um índice da minha lista.

            foreach (Lanche item in minhaLista)
            
                Console.WriteLine($"Lanches disponíveis: {item.Nome}");
            
            Console.WriteLine("Removendo itens...");
            foreach (Lanche item in minhaLista)
            {
                if (item.Quantidade == 5)
                {
                    minhaLista.Remove(item);
                    break;
                }
            }
            
            foreach (Lanche item in minhaLista)
            
                Console.WriteLine($"Lanches disponíveis: {item.Nome}");

            
            Console.ReadKey();
        }
    }
}
