using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça  um  programa  que  mostre  os N primeiros  termos  da  Série  de  Fibonacci,  com  obrigatoriamente maior que 2 :

            int n, soma, num1 = 0, num2 = 1;

            do
            {
                Console.WriteLine("Escreva um número N para fazer a série de Fibonnacci: ");
                n = int.Parse(Console.ReadLine());
            }while(n <= 2);

            for(int i = 0; i < n; i++)
            {
                soma = num1;
                num1 = num2;
                num2 = num1 + soma;
                Console.Write($"{num2}-");
            }

            Console.ReadKey();
        }
    }
}
