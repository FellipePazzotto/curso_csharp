﻿namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota do 1° semestre: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            Console.Write("Digite a nota do 2° semestre: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            Console.Write("Digite a nota do 3° semestre: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            Console.Write("Digite a nota do 4° semestre: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            double nota_final = (nota1 + nota2 + nota3 + nota3) / 4;
            string resultado;

            if (nota_final >= 60)
            {
                if (nota_final >= 90)
                {
                    resultado = "aprovado com mérito, parabéns!!";
                }
                else
                {
                    resultado = "aprovado!!";
                }
            }
            else
            {
                if (nota_final >= 40)
                {
                    resultado = "de recuperação.";
                }
                else
                {
                    resultado = "reprovado..."; 
                }
            }
            Console.WriteLine("A média é {0} o aluno está {1}", 
                nota_final ,resultado);
        }
    }
}
