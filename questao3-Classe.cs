using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest3
{
    //3)Faça uma adaptação no programa feito no exercício 2 para que ele: 
    //a)Suporte a entrada dos dados de 50 alunos (para testar, use os dados de 5 alunos). Use um vetor  para 
    //armazenar esses dados; 
    //b)Liste todos os alunos cadastrados através de uma função específica.
    class aluno
    {
        public string nome;
        public string mail;
        public int telefone;
        public data dataDeNasc;
    }
    class data
    {
        public int dia;
        public int mes;
        public int ano;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            aluno[] alunos = new aluno[50];

            for (int i = 0; i < 50; i++)
            {
                aluno aluno = new aluno();

                Console.WriteLine($"\nNome do aluno{i+1}: ");
                aluno.nome = Console.ReadLine();
                Console.WriteLine("Email do aluno: ");
                aluno.mail = Console.ReadLine();
                Console.WriteLine("Telefone do aluno: ");
                aluno.telefone = int.Parse(Console.ReadLine());

                aluno.dataDeNasc = new data();
                Console.Write("Data de Nascimento do aluno(data em números inteiros)\n - Dia: ");
                aluno.dataDeNasc.dia = int.Parse(Console.ReadLine());
                Console.Write(" - Mês: ");
                aluno.dataDeNasc.mes = int.Parse(Console.ReadLine());
                Console.Write(" - Ano: ");
                aluno.dataDeNasc.ano = int.Parse(Console.ReadLine());

                alunos[i] = aluno;
            }
            Console.Clear();

            foreach (aluno x in alunos)
            {
                Console.WriteLine($"Nome do aluno: {x.nome}");
                Console.WriteLine($"Email: {x.mail}");
                Console.WriteLine($"Telefone: {x.telefone}");
                Console.WriteLine($"Nasceu: {x.dataDeNasc.dia}/{x.dataDeNasc.mes}/{x.dataDeNasc.ano}\n");
            }

            Console.ReadKey();
        }
    }
}
