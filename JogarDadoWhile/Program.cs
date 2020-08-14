using System;
using System.Threading;

namespace JogarDadoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogada = 0;
            while (jogada != 6)
            {
                Console.WriteLine("Jogando dados... Aguarde alguns segundos...");
                Thread.Sleep(500);
                var random = new Random();
                jogada = random.Next(1, 7);
                Console.WriteLine($"Resultado da jogada: {jogada}");
            }
            Console.WriteLine("Saindo da aplicação... ");
        }
    }
}
