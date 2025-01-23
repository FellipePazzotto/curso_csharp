namespace ex016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do produto: R$");
            double produto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("O valor à vista, em dinheiro ou pix, é R${0}.", produto - (0.10 * produto));
            Console.WriteLine("O valor à vista, em cartão, é R${0}.", produto - (0.05 * produto));
            Console.WriteLine("O valor em 2 vezes no cartão é R${0}.", produto);
            Console.WriteLine("O valor em 3 vezes, ou mais, no cartão é R${0}.", produto + (0.20 * produto));
        }
    }
}
