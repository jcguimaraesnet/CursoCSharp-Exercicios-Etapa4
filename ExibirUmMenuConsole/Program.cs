using System;
using System.Threading;

namespace ExibirUmMenuConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcao = string.Empty;
            do
            {
                ExibirMenuPrincipal();
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    DescobrirNumeroParImpar();
                }
                else if (opcao == "2")
                {
                    JogarDado();
                }
                else if (opcao == "3")
                {
                    Console.Write("Saindo do programa... ");
                }
                else if (opcao != "3")
                {
                    Console.Write("Opcao inválida! Escolha uma opção válida. ");
                }

                Console.WriteLine($"Pressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (opcao != "3");
        }

        static void ExibirMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("*** Menu de utilidade *** ");
            Console.WriteLine("1 - Descobrir número par/ímpar:");
            Console.WriteLine("2 - Jogar um dado:");
            Console.WriteLine("3 - Sair:");

            Console.WriteLine("\nEscolha uma das opções acima: ");
        }

        static void DescobrirNumeroParImpar()
        {
            Console.WriteLine("Informe um número inteiro:");
            if (!int.TryParse(Console.ReadLine(), out var numero))
            {
                Console.WriteLine("Número inválido");
                return;
            }
            var resultado = (numero % 2) == 0;
            var parOuImpar = resultado == true ? "par" : "ímpar";
            Console.WriteLine($"O número informado é {parOuImpar}");
        }

        static void JogarDado()
        {
            Console.WriteLine("Jogando dado... Aguarde alguns segundos...");
            Thread.Sleep(2000);

            var random = new Random();
            var jogada = random.Next(1, 7);

            Console.WriteLine($"Resultado da jogada: {jogada}");
        }
    }
}
