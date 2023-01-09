using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia um vetor de 10 posições e chame uma função capaz de contar e 
            //mostrar quantos desses elementos são múltiplos de 3.

            int[] V = new int[10];
            int result;

            Random x = new Random();
            for (int i = 0; i < 10; i++)
            {
                V[i] = x.Next(1, 10);
                Console.Write($"{V[i], 3}");
            }
            Console.WriteLine(".");

            result = multi3(V);

            Console.WriteLine($"A quantidade de múltiplos de 3 que o vetor possui são: {result}");

            Console.ReadKey();
        }

        static int multi3(int[] V)
        {
            int cont = 0;
            for (int i = 0; i < V.Length; i++)
            {
                if(V[i] % 3 == 0)
                {
                    cont++;
                    Console.WriteLine($"O número {V[i]} é múltiplo de 3");
                }
            }
            return cont;
        }
    }
}
