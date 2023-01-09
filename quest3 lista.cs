using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3_pilha
{
    //Faça um programa que cadastre em uma Lista Simplesmente Encadeada e Ordenada 10 números 
    //sorteados aleatoriamente.Mostre o conteúdo da lista ao final. 

    public class Elemento
    {
        public int num;
        public Elemento prox;
        public Elemento()
        {
            num = 0;
            prox = null;
        }
    }
    public class lista
    {
        private Elemento inicio;
        private Elemento fim;
        private Elemento aux;
        private Elemento ant;
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
            }
            else
            {
                ant = null;
                aux = inicio;

                while (aux != null && novo.num > aux.num)
                {
                    ant = aux;
                    aux = aux.prox;
                }

                if (ant == null)
                {
                    novo.prox = inicio;
                    inicio = novo;
                }
                else if (aux == null)
                {
                    fim.prox = novo;
                    fim = novo;
                    fim.prox = null;
                }
                else
                {
                    ant.prox = novo;
                    novo.prox = aux;
                }
            }
            tamanho++;
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
                Console.WriteLine("Lista simplesmente encadeada e ordenada de maneira crescente:");

                while (aux != null)
                {
                    Console.Write($"{aux.num, 6}");
                    aux = aux.prox;
                }
                Console.ReadKey();
            }
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
        }
    }
}
