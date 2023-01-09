using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest2
{
    //2)Repita o exercício anterior, definindo também uma estrutura, ou classe, para suportar o campo Data de Nascimento, 
    //que deverá conter os subcampos Dia, Mês e Ano.
    class aluno
    {
        public string nome;
        public string mail;
        public int telefone;
        public data dataDeNasc;
    }
    class data
    {
        public string dia;
        public string mes;
        public string ano;
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
            Console.WriteLine("Telefone do aluno: ");
            aluno.telefone = int.Parse(Console.ReadLine());

            aluno.dataDeNasc = new data();
            Console.Write("Data de Nascimento do aluno - Dia: ");
            aluno.dataDeNasc.dia = Console.ReadLine();
            Console.Write(" - Mês: ");
            aluno.dataDeNasc.mes = Console.ReadLine();
            Console.Write(" - Ano: ");
            aluno.dataDeNasc.ano = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"- Nome do aluno: {aluno.nome}\n- Email: {aluno.mail} \n- Número de telefone: {aluno.telefone}");
            Console.WriteLine($"Data de nascimento: {aluno.dataDeNasc.dia}/{aluno.dataDeNasc.mes}/{aluno.dataDeNasc.ano}");
            Console.ReadKey();
        }
    }
}
