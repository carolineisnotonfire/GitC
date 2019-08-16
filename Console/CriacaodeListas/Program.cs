using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaodeListas
{
    class Program
    {
        static void Main(string[] args)
        {
            // iniciando lista de string com array linear
            string[] lista = new string[5];//aqui define as posições dalista
                                           //iniciando ela com 10 espaços na memoria
                                           //pra alocar informações de texto

            //laço usado geralmente para andar sobre as posições da lista
            for (int i = 0; i < lista.Length; i++)
            {
                ///carregando os valores da nossa lista
                /// onde i representa cada espaço que temos disponível
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
                ///O datetime é um tipo do dont net c# que dispobibiliza funções relacionadas 
                /// a data e horas, ou seja se precisar trabalhar com essas
                /// informações é possivel usa-lo
            }

            // varre as lista de jeito mais simples
            foreach (var item in lista)

                Console.WriteLine(item); //escreve na tela a informação

            Console.ReadKey();


            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = string.Empty; // limpa o valor da coleção
            }

            Console.ReadKey();
        }
    }
}
