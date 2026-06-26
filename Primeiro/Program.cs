using System;
using System.Runtime.InteropServices;

namespace Primeiro
{
    class Program
    {
        static void Main()
        {
            bool varContinue = true;
            while (varContinue)
            {

                Console.WriteLine("==========Calcuculadora Simples============ \n");
                Console.WriteLine("Digite o primeiro numero:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escolha uma operaçao:");
                Console.WriteLine("1. Adicao (+)");
                Console.WriteLine("2. Subtracao (-)");
                Console.WriteLine("3. Multiplicaçao (*)");
                Console.WriteLine("4. Divisao (*)");
                Console.WriteLine("Digite o numero da operacao: ");
                int operation = Convert.ToInt32(Console.ReadLine());

                double result = 0;

                //Condiçoes

                if (operation == 1)
                {
                    result = num1 + num2;
                }
                else if (operation == 2)
                {
                    result = num1 - num2;
                }
                else if (operation == 3)
                {
                    result = num1 * num2;
                }
                else if (operation == 4)
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;

                    }
                    else
                    {
                        Console.WriteLine("Erro:Nao  e possivel dividir um numero por 0");
                    }

                }
                else
                {
                    Console.WriteLine("Oprecao invalida");
                }

                Console.WriteLine("Resultado:" + result + "\n");

                Console.WriteLine("\n Deseja realizar outra operacao (s/n) ?");
                string response = Console.ReadLine();

                if (response != "s")
                {
                    varContinue = false;
                }
            }
            Console.WriteLine("Obrigado por utilizar a calculadora!");
        }
    }
}
   