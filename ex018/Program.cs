namespace ex018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número de limite: ");
            int final = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("Entre 0 e {0}, os números pares são: ", final);

            for (int i = 1; i <= final; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}, ", i);
                }
            }

            Console.Write("e pronto!!");
        }
    }
}
