namespace ex026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva um medida em metros: ");
            double medida = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------------------------------");

            Console.WriteLine($"A medida em centímetros é {medida * 100} cm.");
            Console.WriteLine($"A medida em milímetros é {medida * 1000} ml.");
        }
    }
}
