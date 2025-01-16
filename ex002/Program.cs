namespace ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 7;
            float num = 2.5f;
            char letra = 'X';
            string nome = "Fellipe";

            Console.WriteLine("O número é {0}.", numero);
            Console.WriteLine("O valor é R${0}.", num);
            Console.WriteLine("O caractere é {0}.", letra);
            Console.WriteLine("O seu nome é {0}.", nome);

            Console.WriteLine("O número é {0}, o valor é R${1}, " +
                "o caractere é {2} e o seu nome é {3}.",
                numero, num, letra, nome);
        }
    }
}
