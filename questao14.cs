using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça  um  programa  que  receba  o  nome  e  a  nota  de  3  provas  realizadas  por  50  alunos.  O 
            //programa deverá ler todos os dados e mostrar a nota final de cada aluno e a média da turma
            //em cada uma das provas. Relacione os alunos com nota final menor que 60 pontos.
            int n, nota1, nota2, nota3;
            double notaT, soma1 = 0, soma2 = 0, soma3 = 0, media1, media2, media3;
            string p1, p2, p3;

            Console.Write("Escreva o número de alunos: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nome da primeira prova: ");
            p1 = Console.ReadLine();
            Console.Write("Nome da segundaa prova: ");
            p2 = Console.ReadLine();
            Console.Write("Nome da terceira prova: ");
            p3 = Console.ReadLine();


            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nota do aluno {i + 1} na {p1}:");
                nota1 = int.Parse(Console.ReadLine());
                Console.Write($"Nota do aluno {i + 1} na {p2}:");
                nota2 = int.Parse(Console.ReadLine());
                Console.Write($"Nota do aluno {i + 1} na {p3}:");
                nota3 = int.Parse(Console.ReadLine());

                notaT = nota1 + nota2 + nota3;

                Console.WriteLine($"A nota final do aluno {i + 1} foi de: {notaT}.");

                if (notaT < 60)
                    Console.WriteLine("O aluno reprovou.");
                else
                    Console.WriteLine("O aluno foi aprovado.");

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
