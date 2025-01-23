namespace ex019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            
            for (int i = 1; i <= 500; i++)
            {
                if (i % 3 == 0)
                {
                    total += i;
                }
            }

            Console.WriteLine("Entre 0 e 500, os números múltiplos de 3 resultam em {0}.", total);
        }
    }
}
