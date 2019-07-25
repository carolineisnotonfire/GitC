using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecebeFrequencia.Classes
{
    public class CriarEmArray
    {

        string[,] ListaAlunos = new string[3, 5];
        Boletim bol = new Boletim();

        public void inserir()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Informe o nome do aluno");
                var nome = Console.ReadLine();
                ListaAlunos[i, 0] = i.ToString();

                ListaAlunos[i, 1] = nome;
                //medias    
                var media = digitaNotas();
                ListaAlunos[i, 2] = media.ToString();

                //informações e frequencia
                Console.WriteLine("Informe o numero de aulas");
                int.TryParse(Console.ReadLine(), out int totalAulas);

                Console.WriteLine("Informe o numero de faltas");
                int.TryParse(Console.ReadLine(), out int numeroFaltas);
                var frequencia = bol.frequencia(totalAulas, numeroFaltas);
                ListaAlunos[i, 3] = frequencia.ToString();
                //informa situação                
                ListaAlunos[i, 4] = bol.RetornaSituacao(media, frequencia);

            }
        }

        public int digitaNotas()
        {
            Console.WriteLine("Informe a nota 1");
            int.TryParse(Console.ReadLine(), out int nota1);

            Console.WriteLine("Informe a nota 2");
            int.TryParse(Console.ReadLine(), out int nota2);

            Console.WriteLine("Informe a nota 3");
            int.TryParse(Console.ReadLine(), out int nota3);

            return bol.SomaNotas(nota1, nota2, nota3);
        }
        public void remover(int pId)
        {
            for (int i = 0; i < ListaAlunos.GetLength(0); i++)
            {
                if (ListaAlunos[i, 0] == pId.ToString())
                {
                    ListaAlunos[i, 0] = "";
                    ListaAlunos[i, 1] = "";
                    ListaAlunos[i, 2] = "";
                    ListaAlunos[i, 3] = "";
                    ListaAlunos[i, 4] = "";
                    break;
                }
            }


        }
        public void alterar(int pId)
        {
            for (int i = 0; i < ListaAlunos.GetLength(0); i++)
            {
                if (ListaAlunos[i, 0] == pId.ToString())
                {
                    var media = digitaNotas();
                    ListaAlunos[i, 2] = media.ToString(); 
                    var frequencia = Convert.ToInt32(ListaAlunos[i, 3]);
                    ListaAlunos[i, 4] = bol.RetornaSituacao(media, frequencia);
                    break;
                }
            }
        }
            public void listar()
            {
            for (int i = 0; i < ListaAlunos.GetLength(0); i++)
            {
                Console.WriteLine($"Id..........: {ListaAlunos[i, 0]}");
                Console.WriteLine($"Nome........: {ListaAlunos[i, 1]}");
                Console.WriteLine($"Média.......: {ListaAlunos[i, 2]}");
                Console.WriteLine($"Frequência..: {ListaAlunos[i, 3]}%");
                Console.WriteLine($"Situação....: {ListaAlunos[i, 4]}\n");
            }

            }
    }
}
