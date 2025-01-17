namespace ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------");

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número digitado é par!!");
            }
            else 
            {
                Console.WriteLine("O número digitado é ímpar!!");
            }
        }
    }
}
