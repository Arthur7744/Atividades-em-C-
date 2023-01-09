using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXproposto1
{
    public class Elemento
    {
        public string matricula;
        public string nome;
        public string mail;
        public string contato;
        public Elemento prox;
        public Elemento ant;
        public Elemento()
        {
            matricula = null;
            nome = null;
            mail = null;
            contato = null;
            prox = null;
            ant = null;
        }
    }
    public class lista
    {
        private Elemento inicio;
        private Elemento fim;
        private Elemento aux;
        public int tamanho;

        public lista()
        {
            inicio = null;
            fim = null;
            tamanho = 0;
        }
        public void Inserir(string matricula, string nome, string mail, string contato)
        {
            bool confirmacao = true;
            int cont = 0;
            Elemento novo = new Elemento();
            novo.matricula = matricula;
            novo.nome = nome;
            novo.mail = mail;
            novo.contato = contato;
            aux = novo;

            if (inicio == null)
            {
                inicio = novo;
                fim = novo;
                novo.prox = null;
                novo.ant = null;
                Console.WriteLine("Dado inserido.");
                tamanho++;
            }
            else 
            {
                novo.prox = inicio;
                inicio = novo;
                Console.WriteLine("Dado inserido");
                tamanho++;
            }
        }
        public void mostraLista()
        {
            Console.Clear();

            if (inicio == null)
            {
                Console.WriteLine("A lista não possui elemento algum. ");
                Console.ReadKey();
            }
            else
            {
                aux = inicio;

                while (aux != null)
                {
                    Console.WriteLine($"| Mátricula: {aux.matricula}| Nome: {aux.nome}| Email: {aux.mail}| Contato: {aux.contato}");
                    aux = aux.prox;
                }
                Console.ReadKey();
            }
        }
        public void EsvaziarLista()
        {
            if (inicio == null)
            {
                Console.WriteLine("A lista já não possui elemento algum para ser esvaziada.\n\n");
                Console.ReadKey();
            }
            else
            {
                inicio = null;
                tamanho = 0;
            }
        }
        public void RetiraElemento(string matricula)
        {
            Console.Clear();

            if (inicio == null)
            {
                Console.WriteLine("A lista não possui nenhum elemento!!! \n\n");
                Console.ReadKey();
            }
            else
            {
                aux = inicio;

                while (aux != null)
                {
                    if (aux.matricula == matricula)
                    {
                        aux = inicio;
                        Console.WriteLine($"O usuário {aux.nome} foi removido da lista");
                        aux = null;
                    }
                    inicio = aux.prox;
                }
            }
            Console.ReadKey();
        }
        public void verificaProfessor(string matricula)
        {
            Console.Clear();
            if (inicio == null)
            {
                Console.WriteLine("A lista já não possui elemento algum para ser esvaziada.\n\n");
                Console.ReadKey();
            }
            else
            {
                aux = inicio;

                while (aux != null)
                {
                    if (aux.matricula == matricula)
                    {
                        Console.WriteLine($"O usuário {aux.nome} esta na lista");
                    }
                    aux = aux.prox;
                }
            }
            Console.ReadKey();
        }
    }
    internal class Programa
    {
        static void Main(string[] args)
        {
            int opcao;
            lista listaProfessores = new lista();

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Inserir Elemento na Lista");
                Console.WriteLine("2 - Mostrar os Elementos da Lista");
                Console.WriteLine("3 - Remover Elemento da Lista por meio da matrícula");
                Console.WriteLine("4 - Esvaziar a Lista");
                Console.WriteLine("5 - Verificar alguém da lista por meio da matricula");
                Console.WriteLine("6 - Sair\n");

                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    string nome, matricula, contato, mail;
                    Console.Clear();

                    Console.Write("Digite a matrícula do professor: ");
                    matricula = Console.ReadLine();
                    Console.Write("Digite o nome do professor: ");
                    nome = Console.ReadLine();
                    Console.Write("Digite o email do professor: ");
                    mail = Console.ReadLine();
                    Console.Write("Digite o número de contato do professor: ");
                    contato = Console.ReadLine();

                    listaProfessores.Inserir(nome, matricula, contato, mail);

                    Console.ReadKey();
                }
                if (opcao == 2)
                {
                    listaProfessores.mostraLista();
                }
                if (opcao == 3)                   
                {
                    string x;                      
                    Console.Clear();           

                    Console.Write("Digite a matricula para remover um usuário da lista: ");            
                    x = Console.ReadLine();                         
                }
                if (opcao == 4)                        
                {
                    Console.Clear();               

                    listaProfessores.EsvaziarLista();

                    Console.WriteLine("Lista Vazia!!\n\n");
                    Console.ReadKey();
                }
                if (opcao == 5)
                {
                    string y;
                    Console.Clear();

                    Console.Write("Digite a matricula para localizar um usuário da lista: ");
                    y = Console.ReadLine();
                    
                    listaProfessores.verificaProfessor(y);
                }

            } while (opcao != 6);

            Console.ReadKey();
        }
    }
}
