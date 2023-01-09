using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um  programa que  chame uma  função capaz  de verificar  se um  número inteiro  de  4
            //algarismos é  palíndromo.Um palíndromo  é identificado  quando a  leitura dele  da esquerda
            //para a  direita é  mesma que  da direita  para a  esquerda,  como,  por exemplo,  1221,  9889, 
            //1001 etc.

            string n;
            char[] V1 = new char [4], V2 = new char [4];
            int i = 0;
            bool result;

            Console.WriteLine($"Escreva um número de 4 algarismos: ");
            n = Console.ReadLine();
            foreach (char x in n)
            {
                V1[i] = x;
                V2[3-i] = x;
                i++;
            }

            result =verificaPalindrono(V1, V2);
            if (result)
                Console.WriteLine($"O número {n} é palíndrono");
            else
                Console.WriteLine($"O número {n} não é palíndrono");

            Console.ReadKey();
        }

       static bool verificaPalindrono(char[] v1, char[] v2)
        {
            bool palin = true;
            int cont = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                if (v1[i] != v2[i])
                {
                    cont++;
                }
            }
            if (cont > 0)
            {
                palin = false;
                return palin;
            }
            else
                return palin;
        }
    }
}
