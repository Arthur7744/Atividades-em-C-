using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça  um  programa  que  contenha  uma  função  capaz  de  receber  uma  matriz  quadrada  de 
            //ordem  “n”  (definida  pelo usuário)  e retornar  outra matriz  que contenha, nas  mesmas
            //posições, os valores dos elementos pares e o valor 0(zero) para os elementos ímpares.
            
            int[,] M, N;
            
            M = PreencherMatriz(3, 3, 1, 30);
            
            Console.WriteLine("\n");

            ImprimirMatriz(M);

            N = MatrizPar(M);

            Console.WriteLine("\n");

            ImprimirMatriz(N);
            
            Console.ReadKey();
        }

        static int[,] PreencherMatriz(int l, int c, int min, int max)
        {
            int[,] M = new int[l, c];
            Random NrRand = new Random();
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = NrRand.Next(min, max + 1);
                }
            }
            return (M);
        }
        static void ImprimirMatriz(int[,] M)
        {
            Console.WriteLine("Sequência: ");
            for (int i = 0; i < M.GetLength(0); i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write($"{M[i, j], 3}");
                }
            }
        }
        static int[,] MatrizPar(int[,] M)
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (M[i, j] % 2 == 0)
                    {
                        M[i, j] = M[i, j];
                    }
                    else
                    {
                        M[i, j] = 0;
                    }
                }
            }
            return (M);
        }
    }
}
