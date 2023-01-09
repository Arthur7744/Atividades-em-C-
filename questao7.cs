using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados  dois  vetores  R  e  S,  cada  um  com  10  posições.  Faça  um  algoritmo  que  leia  os  valores 
            //de R  e S  e gere  o vetor  V resultante  com os  elementos comuns  a R  e S, sem  elementos
            //repetidos.

            int[] R, S, V;
            int nR, nS;

            Console.WriteLine("Escreva o tamanho do primeiro vetor:");
            nR = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o tamanho do segundo vetor:");
            nS = int.Parse(Console.ReadLine());

            R = preencherVetor(nR);
            S = preencherVetor(nS);

            V = repeticao(R, S);

            Console.WriteLine("Os números repetidos são: ");

            for (int i = 0; i < V.Length; i++)
            {
                if(V[i] > 0)
                    Console.Write($"{V[i],3}");
            }
            Console.ReadKey();
        }
        static int[] repeticao(int[] R, int[] S)
        {
            int[] v3 = new int[R.Length];
            int k = 0;

            for (int i = 0; i < R.Length; i++)
            {
                for (int j = 0; j < S.Length; j++)
                {
                    if (R[i] == S[j])
                    {
                        v3[k] = R[i];
                        k++;
                        break;
                    }
                }
            }
            return v3;
        }
        static int[] preencherVetor(int n)
        {

            int[] V = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Insira a {i + 1}° posição: ");
                V[i] = int.Parse(Console.ReadLine());
            }

            return V;
        }


    }
}
