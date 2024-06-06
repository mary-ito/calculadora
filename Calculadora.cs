using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Title = "Calculadora";
                Console.WriteLine("Calculadora em C#");
                Console.WriteLine("--------------------------\n");

                double valor1 = 0, valor2 = 0, resultado = 0, numero;
                string valorDigitado;
                bool isNumeroInteiro;

                // Entrada do primeiro número
                Console.Write("Digite o primeiro número: ");
                valorDigitado = Console.ReadLine();
                isNumeroInteiro = double.TryParse(valorDigitado, out numero);
                if (isNumeroInteiro)
                {
                    valor1 = Math.Round(Convert.ToDouble(valorDigitado), 4);
                }
                else
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                    // Esperar para que o usuário veja a mensagem
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                // Escolha da operação
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("\t1 - Adição (+)");
                Console.WriteLine("\t2 - Subtração (-)");
                Console.WriteLine("\t3 - Multiplicação (*)");
                Console.WriteLine("\t4 - Divisão (/)");
                Console.WriteLine("\t5 - Exponenciação (^)");
                Console.WriteLine("\t6 - Raiz Quadrada (√)");
                Console.WriteLine("\t7 - Módulo (%)");
                Console.Write("Sua escolha: ");
                string operacao = Console.ReadLine();

                // Entrada do segundo número, se necessário
                if (operacao != "6")
                {
                    Console.Write("Digite o segundo número: ");
                    valorDigitado = Console.ReadLine();
                    isNumeroInteiro = double.TryParse(valorDigitado, out numero);
                    if (isNumeroInteiro)
                    {
                        valor2 = Math.Round(Convert.ToDouble(valorDigitado), 4);
                    }
                    else
                    {
                        Console.WriteLine("Número inválido. Tente novamente.");
                        // Esperar para que o usuário veja a mensagem
                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        continue;
                    }
                }

                // Processamento da operação
                switch (operacao)
                {
                    case "1":
                    case "+":
                        resultado = Math.Round(valor1 + valor2, 4);
                        Console.WriteLine($"Resultado: {valor1} + {valor2} = {resultado:F4}");
                        break;
                    case "2":
                    case "-":
                        resultado = Math.Round(valor1 - valor2, 4);
                        Console.WriteLine($"Resultado: {valor1} - {valor2} = {resultado:F4}");
                        break;
                    case "3":
                    case "*":
                        resultado = Math.Round(valor1 * valor2, 4);
                        Console.WriteLine($"Resultado: {valor1} * {valor2} = {resultado:F4}");
                        break;
                    case "4":
                    case "/":
                        if (valor2 != 0)
                        {
                            resultado = Math.Round(valor1 / valor2, 4);
                            Console.WriteLine($"Resultado: {valor1} / {valor2} = {resultado:F4}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        }
                        break;
                    case "5":
                    case "^":
                        resultado = Math.Round(Math.Pow(valor1, valor2), 4);
                        Console.WriteLine($"Resultado: {valor1} ^ {valor2} = {resultado:F4}");
                        break;
                    case "6":
                    case "√":
                        if (valor1 >= 0)
                        {
                            resultado = Math.Round(Math.Sqrt(valor1), 4);
                            Console.WriteLine($"Resultado: √{valor1} = {resultado:F4}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Não é possível calcular a raiz quadrada de um número negativo.");
                        }
                        break;
                    case "7":
                    case "%":
                        resultado = Math.Round(valor1 % valor2, 4);
                        Console.WriteLine($"Resultado: {valor1} % {valor2} = {resultado:F4}");
                        break;
                    default:
                        Console.WriteLine("Operação inválida. Tente novamente.");
                        break;
                }

                // Pergunta se deseja realizar outra operação
                Console.WriteLine("\nDeseja realizar outra operação? (s/n)");
                string continuar = Console.ReadLine();
                if (continuar.ToLower() != "s")
                {
                    break;
                }
            }
        }
    }
}