using System;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            TabuleiroXadrez tab = new(1,2);

            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posição " + P);

            Console.ReadLine();
        }
    }
}
