namespace triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a base do triângulo, em centímetros: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a altura do triângulo, em centímetros: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Linha();

            CalcularArea(x, y);
        }

        static void CalcularArea(int a, int b)
        {
            Console.WriteLine($"Um triângo com base {a} e altura {b} tem área de {(a * b) / 2}cm².");
        }

        static void Linha()
        {
            Console.WriteLine("----------------------------------------------------------------------");
        }
    }
}
