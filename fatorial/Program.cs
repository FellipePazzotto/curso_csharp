namespace fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva um número para ser fatorado: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Você gostaria de ver cálculo (S/N)?? ");
            string resposta = Console.ReadLine().ToLower();

            int resultado = 1;
            Console.WriteLine("-------------------------------------------------------");

            if (resposta == "s")
            {
                for (int i = 1; i <= numero; i++)
                {
                    resultado *= i;

                    if (i < numero)
                    {
                        Console.Write($"{i} x ");
                    }
                    else
                    {
                        Console.Write($"{i} = ");
                    }
                }

                Console.Write(resultado);
            }
            else if (resposta == "n")
            {
                for (int i = 1; i <= numero; i++)
                {
                    resultado *= i;
                }
                
                Console.Write(resultado);
            }
            else
            {
                Console.WriteLine("Você não selecionou uma resposta válida.");
            }
        }
    }
}
