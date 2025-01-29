namespace datas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[] meses = {"janeiro", "fevereiro", "março", "abril", "maio", "junho", 
                "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"};
            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int i = 0; i < meses.Length; i++)
            {
                Console.WriteLine("Em {0} há {1} dias.",
                    meses[i], dias[i]);
            }

            Console.WriteLine();

            string[] dias_semanais = { "domingo", "segunda-feira", "terça-feira",
                "quarta-feira", "quinta-feira", "sexta-feira", "sábado" };

            Console.Write("Semana: ");

            foreach (string dia in dias_semanais)
            {
                Console.Write("{0} || ", dia);
            }*/

            int[] numeros = { 10, 45, 22, 50, 6, -84, -2, 91, -23 };

            Console.WriteLine(numeros.First());
            Console.WriteLine(numeros.Last());
            Console.WriteLine(numeros.Max());
            Console.WriteLine(numeros.Min());
            Console.WriteLine(numeros.Average());
        }
    }
}
