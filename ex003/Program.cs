using System;

namespace ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            float num4, num5;

            Console.Write("Escreva o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------");

            Console.Write("Escreva o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------");

            num3 = num1 + num2;
            Console.WriteLine("A soma entre {0} e {1} é igual a {2}.",
                num1, num2, num3);

            num3 = num1 - num2;
            Console.WriteLine("A subtração entre {0} e {1} é igual a {2}.",
                num1, num2, num3);

            num3 = num1 * num2;
            Console.WriteLine("A multiplicação entre {0} e {1} é igual a {2}.",
                num1, num2, num3);

            num3 = num1 / num2;
            Console.WriteLine("A divisão entre {0} e {1} é igual a {2}.",
                num1, num2, num3);

            num3 = num1 % num2;
            Console.WriteLine("O resto entre {0} e {1} é igual a {2}.",
                num1, num2, num3);

            Console.WriteLine("------------------------------------------------------------");
            Console.Write("Escreva o terceiro número: ");
            num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------");

            num5 = num1 / num4;
            Console.WriteLine("A divisão entre {0} e {1} é igual a {2}.",
                num1, num4, num5);
        }
    }
}
