using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Por meio de funções faça um programa que sorteie elementos de um vetor de tamanho “T”
            //fornecido pelo usuário e inverta a ordem de seus elementos.

            int T;
            int[] V, VI;

            Console.WriteLine("Tamanho do vetor: ");
            T = int.Parse(Console.ReadLine());

            V = new int[T];
            VI = new int[T];

            V = fazVetor(V);
            VI = inverteVetor(V, T);

            Console.Write("\n Vetor original: ");
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i],3}");
            }
            Console.Write("\n Vetor invertido: ");
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{VI[i],3}");
            }

            Console.ReadKey();
        }

        static int[] fazVetor(int[] V)
        {
            Random x = new Random();

            for (int i = 0; i < V.Length; i++)
            {
                V[i] = x.Next(1, 10);
            }

            return V;
        }

        static int[] inverteVetor(int[] V, int T)
        {
            int[] VI = new int[T];
            int p;
            for (int i = 0; i < T; i++)
            {
                p = (T - 1) - i;
                VI[p] = V[i];
            }

            return VI;
        }
    }
}
