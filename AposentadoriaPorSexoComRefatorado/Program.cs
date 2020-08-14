using System;

namespace AposentadoriaPorSexoComRefatorado
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe a sua idade: ");
                var idade = ObterIdade(Console.ReadLine());

                Console.WriteLine("Informe seu sexo. Digite 1 - para Masculino, ou 2 - para Feminino.");
                var sexo = ObterSexo(Console.ReadLine());

                if (EhIdadeDeAposentadoria(idade, sexo))
                    Console.WriteLine("Usuário está em idade de aposentadoria!");
                else
                    Console.WriteLine("Lamento! Usuário não está em idade de aposentadoria.");

            }
            catch (Exception ex)
            {
                Console.Write($"Erro na execução do programa: {ex.Message} ");
                Console.WriteLine($"Execute novamente o programa.");
            }
        }

        static byte ObterIdade(string idadeInformado)
        {
            byte idade;
            try
            {
                idade = byte.Parse(idadeInformado);
            }
            catch (FormatException ex)
            {
                throw new ArgumentException("Formato de número inválido! Execute novamente o programa", ex);
            }
            catch (OverflowException ex)
            {
                throw new ArgumentException($"Idade maior que a capacidade suportada!", ex);
            }

            if (idade == 0 || idade > 130)
                throw new ArgumentException($"Idade igual a zero.");

            return idade;
        }

        static Sexo ObterSexo(string sexoInformado)
        {
            if (!byte.TryParse(sexoInformado, out var sexo))
                throw new ArgumentException("Opção informada para o sexo não é um número válido.");

            if (sexo > 2)
                throw new ArgumentException("Opção de sexo não existente.");

            var sexoEnum = (Sexo)sexo;
            return sexoEnum;

        }
        
        static bool EhIdadeDeAposentadoria(int idade, Sexo sexo)
        {
            const sbyte idadeAposentadoriaMasculino = 65;
            const sbyte idadeAposentariaFeminino = 62;

            var idadeEmFaseDeAposentadoriaFeminino = sexo == Sexo.Feminino && idade >= idadeAposentariaFeminino;
            var idadeEmFaseDeAposentadoriaMasculino = sexo == Sexo.Masculino && idade >= idadeAposentadoriaMasculino;

            var usuarioAptoParaAposentadoria = (idadeEmFaseDeAposentadoriaFeminino || idadeEmFaseDeAposentadoriaMasculino);
            return usuarioAptoParaAposentadoria;
        }
    }
}
