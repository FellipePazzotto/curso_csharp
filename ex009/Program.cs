namespace ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do lado A: ");
            int ladoA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            Console.Write("Digite o valor do lado B: ");
            int ladoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            Console.Write("Digite o valor do lado C: ");
            int ladoC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            if (ladoA < ladoB + ladoC && ladoB < ladoC + ladoA && ladoC < ladoA + ladoB)
            {
                Console.Write("Essas medidas formam um triângulo ");
                if (ladoA == ladoB && ladoB == ladoC && ladoC == ladoA)
                {
                    Console.WriteLine("equilátero!!");
                }
                else if (ladoA != ladoB && ladoB != ladoC && ladoC != ladoA)
                {
                    Console.WriteLine("escaleno!!");
                }
                else
                {
                    Console.WriteLine("isósceles!!");
                }
            }
            else
            {
                Console.WriteLine("Com essas medidas, não é possível formar um triângulo.");
            }
        }
    }
}
