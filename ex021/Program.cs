namespace ex021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = [];
            int soma = 0;
            for (int i = 0; i <= 5; i++)
            {
                Console.Write("Insira o {0}° número: ", i + 1);
                int numero = Convert.ToInt32(Console.ReadLine());
                lista.Add(numero);
                Console.WriteLine("------------------------------------------------------------");
            }

            foreach (var number in lista)
            {
                if (number % 2 == 0)
                {
                    soma += number;
                }
            }

            Console.WriteLine("A soma entre os números pares digitados resulta em {0}.", soma);
        }
    }
}
