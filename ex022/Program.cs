namespace ex022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o 1° termo da PA: ");
            int termo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------------");

            Console.Write("Digite a razão da PA: ");
            int razao  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("Os 10 primeiros termos dessa PA são:");

            for (int i = 0; i <= 9; i++)
            {
                Console.Write("{0}, ", termo += razao);
            }

            Console.WriteLine("e assim por diante.");
        }
    }
}
