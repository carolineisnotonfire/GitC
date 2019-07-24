using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCompacta.Criacao
{
    class CriandoLista
    {
        //Iniciando uma lista de string com array linear
        string[] lista; //aqui definimos as posições da lista iniciando ela com 10
                         //espaços na memoria para alocar informalções de texto
        public CriandoLista()
        {
            lista = new string[10];
            CarregarLista();
            VarrerLista();
            LimparValores();
            VarrerLista();

        }
        public void CarregarLista()
        {
            //laço que usamos geralmente para andar sobre as posições da nossa lista
            for (int i = 0; i < lista.Length; i++)
            {
                //carregando os valores da nossa lista aqui 
                //aonde "i" representa cada espaço que temos disponivel
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
                //DateTime e um tipo do .net c# que disponibiliza funções relacionadas a datas
                //e horas, ou seja se precisar trabalhar com essas informações é possivel usar esse cara.
            }




        }

        public void VarrerLista()
        {
            //Laço de repetição que usamos para varrer nossa lista de maneira mais simples
            foreach (var item in lista)//"var item" indica uma unidade da nossa lista "in lista" 
                //indica a lista que desejamos varrer
                Console.WriteLine(item);//Aqui apresentamos essa informação na tela

            Console.ReadKey();
        }
        
        public void LimparValores()
        {

            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty;//Aqui limpamos o nosso valor dentro da coleção

        }

        
    }
}
