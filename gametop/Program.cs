using System;
using gametop.Lib;

namespace gametop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(
                new Jogador1(),
                new Jogador2());
            jogo.IniciarJogo();
            //Console.WriteLine("Hello World!");
        }

    }
}
