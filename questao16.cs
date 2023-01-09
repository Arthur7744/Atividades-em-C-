using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça  um  programa  que  sorteie  valores  para  preenchimento  de  um  vetor  com  10  posições. 
            //Mostre os elementos que possuem valores repetidos dentro desse vetor. 

            int[] vetor, vetorR = new int[10];

            vetor = CriarVetor(10, 1, 10);
            MostraVetor(vetor);

            Console.WriteLine("Valores Repetidos:");
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetorR.Length; j++)
                {
                    if (vetorR[j] == vetor[i])
                    {
                        Console.WriteLine(vetorR[j]);
                    }
                }
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
                Console.Write($"{vetor[i]}  ");
            }
            Console.WriteLine("\n");
        }
    }
}

