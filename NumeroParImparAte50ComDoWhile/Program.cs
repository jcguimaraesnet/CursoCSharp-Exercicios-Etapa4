using System;

namespace NumeroParImparAte50ComDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeroAtual = 0;
            do
            {
                var resultado = (numeroAtual % 2) == 0;
                var parOuImpar = resultado == true ? "par" : "ímpar";
                Console.WriteLine($"{numeroAtual} - {parOuImpar}");
                numeroAtual++;
            }
            while (numeroAtual <= 50);
        }
    }
}
