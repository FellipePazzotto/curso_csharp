namespace ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a primeira nota: ");
            int nota1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------");

            Console.Write("Insira a segunda nota: ");
            int nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Com as notas {0} e {1}, " +
                "o aluno obteve uma média de {2}.", nota1, nota2, (nota1 + nota2) / 2);
        }
    }
}
