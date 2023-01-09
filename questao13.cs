using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça  um  programa  que  receba  uma  matriz  quadrada  de  ordem  3  e  chame  uma  função  que 
            //seja capaz  de retornar  um vetor  somente com  os elementos  que estão  acima ou  abaixo de
            //sua diagonal principal

            int[,] M = new int[3, 3];
            int[] V;

            Random r = new Random();
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = r.Next(1, 10);
                    Console.Write($"{M[i, j], 6}");
                }
                Console.Write($"\n");
            }

            V = valoresDiagonal(M);
            Console.WriteLine("Os valores são: ");
            for (int i = 0; i < V.Length; i++)
                Console.Write($"{V[i], 3}");


            Console.ReadKey();
        }

        static int[] valoresDiagonal(int[,] M)
        {
            int[] V = new int[6];
            int k = 0;

            for(int i = 0; i < M.GetLength(0); i++)
            {
                for(int j = 0; j < M.GetLength(1); j++)
                {
                    if(i != j)
                    {
                        V[k] = M[i, j];
                        k++;
                    }
                }
            }
            return V;
        }
    }
}
