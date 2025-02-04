namespace escrever
{
    internal class Program
    {
        static void Escrever(string texto)
        {
            int tamanho = texto.Length + 10;
            string linha = new('=', tamanho);
            string centralizado = texto.PadLeft(tamanho - 5).PadRight(tamanho - 5);

            Console.WriteLine(linha);
            Console.WriteLine(centralizado);
            Console.WriteLine(linha);
        }

        static void Main(string[] args)
        {
            Escrever("Seja bem vindo!!");
        }
    }
}
