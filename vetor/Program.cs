using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numero = new int[5];

            numero[0] = 1;
            numero[1] = 2;
            numero[2] = 3;
            numero[3] = 4;
            numero[4] = 5;

            Console.WriteLine(numero[0]);

            int[] num = new int[5] { 10, 20, 30, 40, 50 };

            Console.WriteLine(num[2]);

            int[] n = { 60, 70, 80, 90, 0 };

            Console.WriteLine(n[4]);
            
            Random random = new Random();
            int[] inteiros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                inteiros[i] = random.Next(1, 100);
                Console.WriteLine(inteiros[i]);
            }

            Console.WriteLine();

            double[] reais = new double[10];

            for (int i = 0; i < 10; i++)
            {
                reais[i] = random.NextDouble() * 10000;
                Console.WriteLine(reais[i].ToString("P2"));
            }*/

            string[] nomes = { "Maria", "João", "Paulo", "Ana", "José", "Carla" };

            for (int i = 0; i < nomes.Length; i++)
            {
                if (i < (nomes.Length - 1))
                {
                    Console.Write("{0}, ", nomes[i]);
                }
                else
                {
                    Console.WriteLine("e {0}.", nomes[i]);
                }
            }
        }
    }
}
