using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uma  árvore  A  possui  altura  de  0,80  cm  e  outra  árvore  B  possui  altura  de  1,30  m.  Em  cada 
            //ano,  a árvore  A cresce  12  cm e  a árvore  B cresce  8  cm.Faça um  programa que  mostre em
            //que ano a árvore A ficará maior que a árvore B ?

            double tree1 = 0.8, tree2 = 1.3;
            int ano = 0;

            do
            {
                tree1 = tree1 + 0.12;
                tree2 = tree2 + 0.08;
                ano++;
            }while(tree1 < tree2);

            Console.WriteLine($"A árvore A ficará maior que a árvore B depois de {ano} anos.");
            Console.ReadKey();
        }
    }
}
