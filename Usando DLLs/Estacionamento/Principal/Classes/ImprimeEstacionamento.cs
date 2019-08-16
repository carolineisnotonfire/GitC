using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Classes
{
    class ImprimeEstacionamento
    {
        string[,] listaCarros = new string[3, 5];
        int IDCarro = 0;
        public void inserir()
        {
            for (int i = 0; i < listaCarros.GetLength(0); i++)
            {
                Console.WriteLine("Placa: ");
                var placa = Console.ReadLine();

                Console.WriteLine("Modelo: ");
                var modelo = Console.ReadLine();

                var entrada = Convert.ToString(DateTime.Now);

                listaCarros[i, 0] = (IDCarro++).ToString();
                listaCarros[i, 1] = placa;
                listaCarros[i, 2] = modelo;
                listaCarros[i, 3] = entrada;
                listaCarros[i, 4] = null;                

            }
        }
        public void digitaSaida ()
        {
            for (int i = 0; i < listaCarros.GetLength(0); i++)
            {
                Console.WriteLine($"ID {listaCarros[i, 0]} " +
                          $"- Placa:{listaCarros[i, 1]} " +
                          $"- Modelo:{listaCarros[i, 2]}" +
                          $"Entrada: {listaCarros[i, 3]}");
                if (listaCarros[i,4] == null)
                {
                    Console.WriteLine("");
                }
            }
            
        }
        public void listar()
        {
            Console.WriteLine("Apresentação das informações dentro da base de dados.");
            for (int i = 0; i < listaCarros.GetLength(0); i++)
            {
                    Console.WriteLine($"ID {listaCarros[i, 0]} " +
                          $"- Placa:{listaCarros[i, 1]} " +
                          $"- Modelo:{listaCarros[i, 2]}" +
                          $"Entrada: {listaCarros[i,3]}");
            }
        }
    }

}
