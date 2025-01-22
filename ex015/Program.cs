namespace ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva o peso da pessoa: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escreva a altura da pessoa: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.Write("Com o IMC de {0}, o usuário está com ", imc);

            if (imc < 18.5)
            {
                Console.WriteLine("abaixo do peso.");
            }
            else if (imc < 25)
            {
                Console.WriteLine("o peso ideal.");
            }
            else if (imc < 30)
            {
                Console.WriteLine("sobrepeso.");
            }
            else if (imc < 40)
            {
                Console.WriteLine("obesidade.");
            }
            else
            {
                Console.WriteLine("obesidade mórbida.");
            }
        }
    }
}
