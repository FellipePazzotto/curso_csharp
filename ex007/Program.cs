﻿namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final = 30;
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
            Console.WriteLine("Com a nota de {0}, aluno está {1}", 
                nota_final ,resultado);
        }
    }
}
