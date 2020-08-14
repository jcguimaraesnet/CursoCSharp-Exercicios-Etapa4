using System;

namespace NumeroParImparAte50ComWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeroAtual = 1;
            while (numeroAtual <= 50)
            {
                var resultado = (numeroAtual % 2) == 0;
                var parOuImpar = resultado == true ? "par" : "ímpar";
                Console.WriteLine($"{numeroAtual} - {parOuImpar}");
                numeroAtual++;
            }
        }
    }
}
