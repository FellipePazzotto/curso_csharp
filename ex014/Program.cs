namespace ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o ano de nascimento do atleta: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Console.Write("O atleta irá competir na categoria ");
            if (2025 - ano <= 9)
            {
                Console.WriteLine("mirim.");
            }
            else if (2025 - ano <= 14)
            {
                Console.WriteLine("infantil.");
            }
            else if (2025 - ano <= 19)
            {
                Console.WriteLine("júnior.");
            }
            else if (2025 - ano <= 25)
            {
                Console.WriteLine("sênior.");
            }
            else
            {
                Console.WriteLine("master.");
            }
        }
    }
}
