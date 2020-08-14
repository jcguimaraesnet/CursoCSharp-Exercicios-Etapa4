using System;
using System.Globalization;
using System.Threading;

namespace AposentadoriaPorSexoComTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            const sbyte idadeAposentadoriaMasculino = 65;
            const sbyte idadeAposentariaFeminino = 62;

            Console.WriteLine("Informe a sua idade: ");
            byte idade;
            try
            {
                idade = byte.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Formato de número inválido! Execute novamente o programa. Erro: {ex.Message}");
                return;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Idade maior que a capacidade suportada! Execute novamente o programa. Erro: {ex.Message}");
                return;
            }

            Console.WriteLine("Informe seu sexo. Digite 1 - para Masculino, ou 2 - para Feminino.");
            if (!uint.TryParse(Console.ReadLine(), out var sexoInformado) && sexoInformado > 2)
            {
                Console.WriteLine("Opção de sexo inválido. Execute novamente o programa.");
                return;
            }
            var sexo = (Sexo)sexoInformado;

            var idadeEmFaseDeAposentadoriaFeminino = sexo == Sexo.Feminino && idade >= idadeAposentariaFeminino;
            var idadeEmFaseDeAposentadoriaMasculino = sexo == Sexo.Masculino && idade >= idadeAposentadoriaMasculino;
            if (idadeEmFaseDeAposentadoriaFeminino || idadeEmFaseDeAposentadoriaMasculino)
            {
                Console.WriteLine("Usuário está em idade de aposentadoria!");
            }
            else
            {
                Console.WriteLine("Lamento! Usuário não está em idade de aposentadoria.");
            }
        }
    }
}
