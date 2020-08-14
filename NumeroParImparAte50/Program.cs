using System;

namespace NumeroParImparAte50
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 50; i++)
            {
                var resultado = (i % 2) == 0;
                //operador ternário ? : 
                var parOuImpar = resultado == true ? "par" : "ímpar";
                Console.WriteLine($"{i} - {parOuImpar}");
            }
        }
    }
}
