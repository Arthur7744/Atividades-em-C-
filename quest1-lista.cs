using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
        //Faça  um  programa  que  leia  do  teclado  uma  string  qualquer.  Crie  uma  Lista  Simplesmente 
        //Encadeada e não Ordenada que insira cada letra dessa string no início dessa lista ou no final,
        //dependendo da opção do usuário.
    internal class Program
    {
        class caixa
        {
            public char letra;
            public caixa prox;
            public caixa ant;

            public caixa()
            {
                letra = '\0';
                prox = null;
                ant = null;
            }
        }
        class Lista
        {
            private caixa inicio;
            private caixa fim;
            private caixa aux;

            public int tamanho;

            public Lista()
            {
                inicio = null;
                fim = null;

                tamanho = 0;
            }

            public void InserirInicio(char valor)
            {
                caixa Nova = new caixa();

                Nova.letra = valor;

                if (inicio == null)
                {
                    inicio = Nova;
                    fim = Nova;
                }
                else
                {
                    Nova.prox = inicio;
                    inicio.ant = Nova;
                    inicio = Nova;
                }

                tamanho++;
            }

            public void InserirFinal(char valor)
            {
                caixa Nova = new caixa();

                Nova.letra = valor;

                if (inicio == null)
                {
                    inicio = Nova;
                    fim = Nova;
                }
                else
                {
                    fim.prox = Nova;
                    Nova.ant = fim;
                    fim = Nova;
                }

                tamanho++;
            }
            public void MostraListaFeita()
            {
                Console.Clear();

                Console.WriteLine($"Total de Elementos: {tamanho}\nLista formada: \n");

                aux = inicio;

                while (aux != null)
                {
                    Console.Write($"{aux.letra,3}");

                    aux = aux.prox;
                }
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            string R;
            Lista listaDeLetras = new Lista();
            int i = 0, opcao;
            Console.WriteLine("Escreva uma palavra qualquer: ");
            R = Console.ReadLine();

            foreach (char x in R)
            {
                Console.Clear();
                i++;
                Console.WriteLine($"Onde você deseja colocar a letra da posição {i + 1}:\n Aperte 1 para colocar no início\n Aperte 2 para colocar no fim\n");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    listaDeLetras.InserirInicio(x);
                }
                else
                    listaDeLetras.InserirFinal(x);

            }
            listaDeLetras.MostraListaFeita();

            Console.ReadKey();
        }
    }
}
