using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia as notas de 3 provas de 20 alunos e calcule o total de pontos de
            //cada aluno e a média de pontos da turma em cada uma das 3 provas.

            int n, nota1, nota2, nota3;
            double notaT, soma1 = 0, soma2 = 0, soma3 = 0, media1, media2, media3;

            Console.Write("Escreva o número de alunos: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nota do aluno {i+1} na primeira prova:");
                nota1 = int.Parse(Console.ReadLine());
                Console.Write($"Nota do aluno {i + 1} na segunda prova:");
                nota2 = int.Parse(Console.ReadLine());
                Console.Write($"Nota do aluno {i + 1} na terceira prova:");
                nota3 = int.Parse(Console.ReadLine());

                notaT = nota1 + nota2 + nota3;

                Console.WriteLine($"A nota total do aluno {i + 1} foi de: {notaT}.");

                Console.ReadKey();

                soma1 = soma1 + nota1;
                soma2 = soma2 + nota2;
                soma3 = soma3 + nota3;
            }

            media1 = soma1 / n;
            media2 = soma2 / n;
            media3 = soma3 / n;

            Console.WriteLine($"A média de pontos da turma na prova 1 foi: {media1}. ");
            Console.WriteLine($"A média de pontos da turma na prova 2 foi: {media2}. ");
            Console.WriteLine($"A média de pontos da turma na prova 3 foi: {media3}. ");

            Console.ReadKey();
        }
    }
}
