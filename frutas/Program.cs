namespace frutas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = {"Maçã", "Melão", "Mamão", "Kiwi", "Goiaba",
                "Melância", "Graviola", "Morango", "Pêra", "Laranja"};

            double[] valores = { 10, 8.50, 3.25, 4, 7, 9, 10.5, 9, 10.75, 9.15 };

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine("{0} ---> R${1}", frutas[i], valores[i]);
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("O maior preço entre as frutas é de R${0}", 
                valores.Max());
            Console.WriteLine("O menor preço entre as frutas é de R${0}",
                valores.Min());
            Console.WriteLine("A média de preço entre as frutas é de R${0}",
                valores.Average());
        }
    }
}
