using System;
using System.Threading;

namespace JogarDadoDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int jogada;
            var random = new Random();
            do
            {
                Console.WriteLine("Jogando dados... Aguarde alguns segundos...");
                Thread.Sleep(500);
                jogada = random.Next(1, 7);
                Console.WriteLine($"Resultado da jogada: {jogada}");
            } while (jogada != 6);

            Console.WriteLine("Saindo da aplicação... ");
        }
    }
}
