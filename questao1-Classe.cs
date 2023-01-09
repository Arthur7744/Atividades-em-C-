using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aed_classes
{
    //1)Faça um programa que defina uma estrutura ou classe contendo o Nome, Mail, Data de Nascimento e Telefone de um 
    //Aluno.Insira dados de exemplo nessa estrutura e depois liste seu conteúdo.
    class aluno
    {
        public string nome;
        public string mail;
        public string data;
        public int telefone;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            aluno aluno = new aluno();

            Console.WriteLine("\nNome do aluno: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Email do aluno: ");
            aluno.mail = Console.ReadLine();
            Console.WriteLine("Data de Nascimento do aluno: ");
            aluno.data = Console.ReadLine();
            Console.WriteLine("Telefone do aluno: ");
            aluno.telefone = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"-Nome do aluno: {aluno.nome}\n-Email: {aluno.mail} \n-Nascimento: {aluno.data} \n-Número de telefone: {aluno.telefone}");

            Console.ReadKey();
        }
    }
}
