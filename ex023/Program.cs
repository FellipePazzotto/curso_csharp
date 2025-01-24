namespace ex023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o gênero do indivíduo: ");
            string genero = Console.ReadLine().ToUpper();
            Console.WriteLine("----------------------------------------");

            while (genero != "F" && genero != "M")
            {
                Console.Write("Digite o gênero do indivíduo: ");
                genero = Console.ReadLine().ToUpper();
                Console.WriteLine("----------------------------------------");
            }

            if (genero == "F")
            {
                Console.WriteLine("Seja bem vinda!!");
            }
            else
            {
                Console.WriteLine("Seja bem vindo!!");
            }
        }
    }
}
