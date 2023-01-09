using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tem - se  um conjunto  de dados  contendo a  altura,  idade e  o sexo(M ou  F)  de  15  pessoas.Faça um programa que calcule e mostre:

            int n;
            Console.WriteLine("Escreva a quantidade de pessoas a serem avaliadas: ");
            n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            int[] idades = new int[n];
            string[] sexos = new string[n];

            Avaliacao(alturas, idades, sexos);

            //A maior e menor altura do grupo
            double MaiorH = alturas[0], MenorH = alturas[0];

            for (int i = 0; i < n; i++)
            {
                if (alturas[i] > MaiorH)
                    MaiorH = alturas[i];
                if (alturas[i] < MenorH)
                    MenorH = alturas[i];
            }

            Console.WriteLine($"Maior altura: {MaiorH}");
            Console.WriteLine($"Menor altura: {MenorH}");

            //A média de altura das mulheres

            int contH = 0, contM = 0, Nhomens = 0;
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine($"Sexo da pessoa {j + 1}: digite F(feminino) ou M(masculino) obrigatoriamente. ");
                sexos[j] = Console.ReadLine();
                if (sexos[j] == "F")
                    contM++;
                else
                    contH++;
            }

            double mediaM = 0, somaM = 0;
            

            for (int i = 0; i < n; i++)
            {
                if (sexos[i] == "F")
                {
                    somaM = somaM + alturas[i];
                }
                //O número de homens com idade entre 40 e 50 anos
                else
                {
                    if((idades[i] >= 40) && (idades[i] <= 50))
                        Nhomens++;  
                }

            }
            mediaM = somaM / contM;
            Console.WriteLine($"Média de altura das mulheres: {mediaM}");
            Console.WriteLine($"O número de homens com idade entre 40 e 50 anos: {Nhomens}");

            Console.ReadKey();
        }

        static void Avaliacao(double[] h, int[] a, string[] s)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Avaliação da pessoa {i + 1}");
                Console.WriteLine("Altura: ");
                h[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Idade: ");
                a[i] = int .Parse(Console.ReadLine());

            }
        }
    }
}
