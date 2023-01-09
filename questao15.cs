using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que contenha uma função capaz de gerar o Super Fatorial de um número 
            //inteiro.O Super Fatorial é dado pela fórmula:

            int n, SF;

            Console.WriteLine("Escreva um número para gerar seu super fatorial: ");
            n = int.Parse(Console.ReadLine());


            SF = superFatorial(n, n);

            Console.WriteLine(SF);

            Console.ReadKey();
        }
        static int superFatorial(int n, int m)
        {
            if (m == 1) 
                return 1;

            if (n == 1)
                return superFatorial(m - 1, m - 1);

            return n * superFatorial(n - 1, m);
        }
    }
}
