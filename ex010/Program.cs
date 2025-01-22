namespace ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu salário: R$");
            double salario = Convert.ToDouble(Console.ReadLine());

            if (salario > 2500)
            {
                salario += (0.05 * salario);
            }
            else if (salario > 1250 && salario < 2500)
            {
                salario += (0.10 * salario);
            }
            else
            {
                salario += (0.15 * salario);
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Após o aumento, o valor do salário é R${0}.", salario);
        }
    }
}
