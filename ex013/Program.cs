namespace ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu ano de nascimento: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            if (2025 - ano == 18)
            {
                Console.WriteLine("Você deve se alistar esse ano.");
            }
            else if (2025 - ano > 18)
            {
                Console.WriteLine("Você deveria se alistar no ano de {0}.", ano + 18);
            }
            else
            {
                Console.WriteLine("Você precisa se alistar no ano de {0}.", ano + 18);
            }
        }
    }
}
