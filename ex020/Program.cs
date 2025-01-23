namespace ex020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", 
                    numero, i, numero * i);
            }
        }
    }
}
