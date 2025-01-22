namespace ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");

            if (numero1 > numero2)
            {
                Console.WriteLine("O número {0} é maior que o número {1}.", 
                    numero1, numero2);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("O número {0} é maior que o número {1}.",
                    numero2, numero1);
            }
            else
            {
                Console.WriteLine("Os número são iguais!!");
            }
        }
    }
}
