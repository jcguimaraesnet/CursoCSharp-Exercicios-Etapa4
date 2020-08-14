using System;
using System.Globalization;

namespace FinalDeSemanaSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua data de aniversário (formato: dd/mm/yyyy): ");
            if (!DateTime.TryParse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("pt-BR"), DateTimeStyles.None, out var dataAniversario))
            {
                Console.WriteLine("Formato de data inválida. Execute novamente o programa.");
                return;
            }
            var descricaoDia = ObterDescricaoDia(dataAniversario);
            Console.WriteLine($"Você nasceu num {descricaoDia}!");
        }

        static string ObterDescricaoDia(DateTime aniversario)
        {
            switch (aniversario.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return "final de semana";
                default:
                    return "dia de semana";
            }

        }
    }
}
