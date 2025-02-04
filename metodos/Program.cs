namespace metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saudacao("Fellipe");
            Soma(7, 8);
        }

        static void Saudacao(string nome)
        {
            Console.WriteLine($"Olá {nome}, seja bem vindo!!");
        }

        static void Soma(int numero1, int numero2)
        {
            Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
        }
    }
}
