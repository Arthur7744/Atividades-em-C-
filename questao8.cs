using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados dois  vetores R  e S, cada  um com  10  posições.Faça um  algoritmo que  leia os  valores
            //de  R e  S e  gere o  vetor V  resultante com  os elementos  de R  que não  existem em  S,  sem
            //repetição.

            int[] R, S, V;

            R = CriarVetor(10, 1, 50);
            MostraVetor(R);
            S = CriarVetor(10, 1, 100);
            MostraVetor(S);


            V = repeticao(R, S);
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i], 3}");
            }

            Console.ReadKey();
        }
        static int[] CriarVetor(int n, int min, int max)
        {
            int[] vetor = new int[n];
            Random NrRand = new Random();

            for (int i = 0; i < n; i++)
            {
                vetor[i] = NrRand.Next(min, max + 1);
            }
            return (vetor);
        }
        static void MostraVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{vetor[i], 3}");
            }
            Console.WriteLine("\n");
        }
        static int[] repeticao(int[] R, int[] S)
        {
            int[] V = new int[10];
            int k = 0;


            for (int i = 0; i < R.Length; i++)
            {
                for (int j = 0; j < S.Length; j++)
                {
                    if (R[i] != S[j])
                    {
                        V[k] = R[i];
                        k++;
                        break;
                    }
                }
            }
            return V;

        }
    }
}
