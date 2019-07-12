using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarReceita
{
    class Program
    {
        static List<string> ingredientesBolo;
        static void Main(string[] args)
        {
            BoasVindas();
            ListaIngredientes();
            BoloEnter();
        }
        /// <summary>
        /// O 'BoasVindas' serve para ter um ambiente mais familiar ao console.
        /// </summary>
        public static void BoasVindas()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Vamos fazer um bolo? :)");
            Console.WriteLine("========================");

        }
        /// <summary>
        /// A ListaIngredientes é um método utilizado para listar os ingredientes e também o modo de preparo do bolo.
        /// </summary>
        public static void ListaIngredientes()
        {
            ingredientesBolo = new List<string>();
            ingredientesBolo.Add("Ingredientes");
            ingredientesBolo.Add("2 xícaras (chá) de açúcar");
            ingredientesBolo.Add("3 xícaras (chá) de farinha de trigo");
            ingredientesBolo.Add("4 colheres (sopa) de margarina");
            ingredientesBolo.Add("3 ovos");
            ingredientesBolo.Add("1 e 1/2 xícara (chá) de leite");
            ingredientesBolo.Add("Modo de preparo");
            ingredientesBolo.Add("Bata as claras em neve e reserve.");
            ingredientesBolo.Add("Misture as gemas, a margarina e o açúcar até obter uma massa homogênea.");
            ingredientesBolo.Add("Acrescente o leite e a farinha de trigo aos poucos, sem parar de bater.");
            ingredientesBolo.Add("Por último, adicione as claras em neve e o fermento.");
            ingredientesBolo.Add("Despeje a massa em uma forma grande de furo central untada e enfarinhada.");
            ingredientesBolo.Add("Asse em forno médio 180 °C, preaquecido, por aproximadamente 40 minutos ou ao furar o bolo com um garfo, este saia limpo.");
        }
        /// <summary>
        /// Este método serve para ler toda a lista de ingredientes + o modo de preparo, conforme o usuário aperta o Enter, ele escreve cada item da lista.
        /// </summary>
        public static void BoloEnter()
        { 
            foreach (var item in ingredientesBolo)
            {
                Console.ReadKey();
                Console.WriteLine(item);
            }
        }
    }
}
