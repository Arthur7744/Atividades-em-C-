
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXproposto2
{
    class Elemento
    {
        public int senha;
        public Elemento prox;

        public Elemento()
        {
            senha = 0;
            prox = null;
        }
    }

    class Fila
    {
        private Elemento inicio;
        private Elemento fim;
        private Elemento aux;

        public Fila()
        {
            inicio = null;
            fim = null;
            aux = null;
        }

        public void RetirarSenha(int Valor)
        {
            Elemento Novo = new Elemento();

            Novo.senha = Valor;

            if (inicio == null)
            {
                inicio = Novo;
                fim = Novo;
            }
            else
            {
                fim.prox = Novo;
                fim = Novo;
            }
            Console.WriteLine($"\nSenha colocada no fim da fila.");
            Console.ReadKey();
        }

        public void MostrarSenhas()
        {
            int tamanho = 0;
            Console.Clear();
            Console.WriteLine("SENHAS QUE SE ENCONTRAM NA FILA");

            aux = inicio;

            while (aux != null)
            {
                tamanho++;
                Console.WriteLine($"posição:{tamanho}/ Senha: {aux.senha}");
                aux = aux.prox;
            }
            Console.ReadKey();
        }

        public int RetiraNum()
        {
            int x;

            x = inicio.senha;

            inicio = inicio.prox;

            return x;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, x, i = 0;
            Fila filaDeEspera = new Fila();

            do
            {
                Console.Clear();
                i++;
                Console.WriteLine("\n\n\n ---MENU DE ATENDIMENTO--- \n\n\n");
                Console.WriteLine("Aperte 1 para retirar senha.");
                Console.WriteLine("Aperte 2 para confirmar que foi atendido");
                Console.WriteLine("Aperte 3 para que veja a quantidade de senhas na sua frente.");
                Console.WriteLine("Aperte 4 para desligar e sair do menu.\n");

                Console.Write("Digite as opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Random papel = new Random();
                    x = i;
                    Console.WriteLine($"\nSenha número {x} foi retirada.");
                    Console.ReadKey();
                    filaDeEspera.RetirarSenha(x);
                }
                if (opcao == 2)
                {
                    filaDeEspera.RetiraNum();
                }
                if(opcao == 3)
                {
                    filaDeEspera.MostrarSenhas();
                }
            }while (opcao != 4);
            Console.ReadKey();
        }
    }
}
