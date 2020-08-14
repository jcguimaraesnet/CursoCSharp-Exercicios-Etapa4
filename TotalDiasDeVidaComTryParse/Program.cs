using System;
using System.Globalization;

namespace TotalDiasDeVidaComTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture("pt-BR");

            Console.WriteLine("Informe sua data de aniversário (formato: dd/mm/yyyy): ");

            //outra forma
            //if (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dataAniversario1))
            //    throw new ArgumentException("Não existe data na linha atual do acces");

            if (!DateTime.TryParse(Console.ReadLine(), cultureInfo, DateTimeStyles.None, out var dataAniversario))
            {
                Console.WriteLine("Formato de data inválida. Execute novamente o programa.");
                return;
            }

            var totalDiasDeVida = DateTime.Now - dataAniversario;
            Console.WriteLine($"Total de dias de vida até o hoje: {totalDiasDeVida.TotalDays:N2}");
        }
    }
}
