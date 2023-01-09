using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados  dois  vetores  R  e  S,  cada  um  com  10  posições.  Faça  um  algoritmo  que  leia  os  valores 
            //de R e S e gere o vetor V resultante da união dos dois, sem elementos repetidos.

            int[] R = new int[10], S = new int[10], V = new int[20];

            Random x = new Random();

            for (int i = 0; i < 10; i++)
            {
                R[i] = x.Next(1, 30);
                S[i] = x.Next(1, 30);
            }

            mostraVetor(R);
            mostraVetor(S);
            for (int i = 0; i < R.Length; i++)
            {
                for (int j = 0; j < S.Length; j++)
                {
                    if(R[i] != S[j])
                    {
                        V[i] = R[i];
                    }
                }
            }
            for (int i = 0; i < S.Length; i++)
            {
                for (int j = 0; j < R.Length; j++)
                {
                    if (S[i] != R[j])
                    {
                        V[i + 10] = S[i];
                    }
                }
            }
            mostraVetor(V);

            Console.ReadKey();
        }

        static void mostraVetor(int[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i], 3}");    
            }
            Console.WriteLine(".");
        }
    }
}
