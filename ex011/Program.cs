namespace ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da casa a ser comprada: R$");
            double casa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------");

            Console.Write("Digite o valor do salário do comprador: R$");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------");

            Console.Write("Digite em quantos anos a casa será paga: ");
            int anos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------");

            int meses = anos * 12;
            Console.WriteLine("A parcela mensal da casa é equivalente a R${0}.",
                    casa / meses);
            Console.Write("Situação do financiamento: ");

            if (0.30 * salario > casa / meses)
            {
                Console.WriteLine("aprovado.");
            }
            else
            {
                Console.WriteLine("reprovado.");
            }
        }
    }
}
