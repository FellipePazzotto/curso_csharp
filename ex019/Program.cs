namespace ex019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int quantidade = 0;
            
            for (int i = 1; i <= 500; i++)
            {
                if (i % 3 == 0)
                {
                    total += i;
                    quantidade++;
                }
            }

            Console.WriteLine("Entre 0 e 500, há {0} números múltiplos de 3 e" +
                " a soma deles resulta em {1}.", quantidade, total);
        }
    }
}
