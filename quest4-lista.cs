using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4_lista
{
    //Faça um programa solicite a entrada, pelo usuário, de uma string de algarismos numéricos. O 
    //programa deverá decompor essa string e criar duas listas, de qualquer natureza, uma contendo
    //somente os números pares e outra apenas os números ímpares dessa string. Mostre o resultado
    //final das duas listas.

    internal class Program
    {
        class Elemento
        {
            public int num;
            public Elemento Prox;

            public Elemento()
            {
                Prox = null;
            }
        }

        class Lista
        {
            public Elemento Inicio;
            public Elemento Fim;
            public Elemento Aux;

            public Lista()
            {
                Inicio = null;
                Fim = null;
                Aux = null;
            }

            public void TrataString(string F)
            {
                Elemento Novo;

                for (int i = 0; i < F.Length; i++)
                {
                    Novo = new Elemento();

                    Novo.num = (int)char.GetNumericValue(F[i]);

                    if (Inicio == null)
                    {
                        Inicio = Novo;
                        Fim = Novo;
                    }
                    else
                    {
                        Fim.Prox = Novo;
                        Fim = Novo;
                    }
                }
            }

            public void ListaPares()
            {
                Aux = Inicio;
                while (Aux != null)
                {
                    if (Aux.num % 2 == 0)
                    {
                        Console.Write($"{Aux.num,6}");
                    }
                    Aux = Aux.Prox;
                }
            }

            public void ListaImpares()
            {
                Aux = Inicio;
                while (Aux != null)
                {
                    if (Aux.num % 2 == 1)
                    {
                        Console.Write($"{Aux.num,6}");
                    }
                    Aux = Aux.Prox;
                }
            }
        }

        static void Main(string[] args)
        {
            string num;
            Lista MinhaLista = new Lista();

            Console.Write("Digite qualquer valor numérico:   ");
            num = Console.ReadLine();

            MinhaLista.TrataString(num);

            Console.Clear();

            Console.WriteLine("Lista de pares: ");
            MinhaLista.ListaPares();
            Console.WriteLine("\n\nLista de ímpares: ");
            MinhaLista.ListaImpares();
            Console.ReadKey();

        }
    }
}
