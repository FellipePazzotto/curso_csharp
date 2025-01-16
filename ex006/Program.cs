namespace ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------");

            Console.Write("Digite a primeira nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Com as notas {0} e {1}, " +
                "o aluno obteve uma média de {2}.", nota1, nota2, (nota1 + nota2) / 2);
        }
    }
}
