using System;
using System.Threading;

namespace CaraOuCoroaComEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogando moeda... Aguarde alguns segundos...");
            Thread.Sleep(2000);

            var random = new Random();
            var faceMoeda = (FaceMoeda)random.Next(0, 2);

            Console.Write($"Resultado da jogada: {faceMoeda}!");
        }
    }
}
