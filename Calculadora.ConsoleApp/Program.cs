namespace Calculadora.ConsoleApp
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculadora Tabajara 2024");

                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");

                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao != "S" && operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4")
                {
                    Console.WriteLine("Informe uma opção válida");
                    continue;
                }
                else if (operacao == "S")
                {
                    break;
                }

                Console.WriteLine("Informe o primeiro número: ");
                string primeiroNumeroString = Console.ReadLine();
                double primeiroNumero = Double.Parse(primeiroNumeroString);

                Console.WriteLine("Informe o segundo número: ");
                string segundoNumeroString = Console.ReadLine();
                double segundoNumero = Double.Parse(segundoNumeroString);

                double resultado = 0;

                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                else if (operacao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }

                else if (operacao == "4")
                {
                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Informe um número válido, não é possível dividir por 0");
                    }
                    else
                    {
                        resultado = primeiroNumero / segundoNumero;
                    }

                }
                Console.WriteLine("O resultado é: " + resultado.ToString("N2"));
                Console.ReadLine();

            }
        }
    }
}