namespace calculo_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a largura do terreno, em metros: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o comprimento do terreno, em metros: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            Terreno(largura, comprimento);
        }

        static void Terreno(double b, double l)
        {
            Console.WriteLine($"Um terreno {b:F2}m X {l:F2}m possui {b * l:F2}m².");
        }
    }
}
