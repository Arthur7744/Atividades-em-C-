using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5_lista
{
    //Faça um programa que crie uma Lista Duplamente Encadeada, Ordenada ou não, com números 
    //aleatórios.O usuário deverá selecionar uma opção e “andar” do início ao fim da lista ou do fim ao
    //início da lista mostrando cada número entrado.
    public class Elemento
    {
        public int num;
        public Elemento prox;
        public Elemento ant;
        public Elemento()
        {
            num = 0;
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
        public void Inserir(int numero)
        {
            Elemento novo = new Elemento();
            novo.num = numero;

            if (inicio == null)
            {
                inicio = novo;
                fim = novo;
                novo.prox = null;
                novo.ant = null;
            }
            else
            {
                novo.prox = inicio;
                inicio.ant = novo;
                inicio = novo;
            }
            tamanho++;
        }
        public void mostraLista()
        {
            int Op;

            do
            {
                Console.Clear();
                Console.WriteLine("\n Por onde quer começar a contagem? (início = 1 ou fim = 2)");
                Op = int.Parse(Console.ReadLine());

                Console.WriteLine("Aperte enter para andar continuamente.\n");
                if (Op == 1)
                {
                    aux = inicio;

                    while (aux != null)
                    {
                        Console.ReadKey();
                        Console.WriteLine($"{aux.num}");
                        aux = aux.prox;
                    }
                    Console.ReadKey();


                }
                else
                {
                    aux = fim;

                    while (aux != null)
                    {
                        Console.ReadKey();
                        Console.WriteLine($"{aux.num}");
                        aux = aux.ant;
                    }
                    Console.ReadKey();
                }
            } while (Op < 3);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            lista listaAleatoria = new lista();
            listaAleatoria.Inserir(x.Next(1, 300));
            listaAleatoria.Inserir(x.Next(1, 300));
            listaAleatoria.Inserir(x.Next(1, 300));
            listaAleatoria.Inserir(x.Next(1, 300));
            listaAleatoria.Inserir(x.Next(1, 300));
            listaAleatoria.Inserir(x.Next(1, 300));
            listaAleatoria.Inserir(x.Next(1, 300));
            listaAleatoria.Inserir(x.Next(1, 300));
            listaAleatoria.Inserir(x.Next(1, 300));
            listaAleatoria.Inserir(x.Next(1, 300));

            listaAleatoria.mostraLista();

            Console.ReadKey();
        }
    }
}
