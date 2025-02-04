namespace votacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu ano de nascimento: ");
            int nasc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Voto(nasc));
        }

        static string Voto(int ano)
        {
            DateTime data_atual = DateTime.Now;
            int ano_atual = data_atual.Year;
            int idade = ano_atual - ano;

            if (idade < 16)
            {
                return $"Com {idade} anos, não é possível votar.";
            }
            else if (idade >= 18 && idade < 70)
            {
                return $"Com {idade} anos, o voto é obrigatório.";
            }
            else
            {
                return $"Com {idade} anos, o voto é opcional.";
            }
        }
    }
}
