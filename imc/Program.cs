namespace imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira sua altura, em metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira seu peso, em quilos: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.Write($"Com {imc:F} de IMC, você está abaixo do peso.");
            }
            else if (imc > 18.5 && imc < 24.9)
            {
                Console.Write($"Com {imc:F} de IMC, você está com o peso normal.");
            }
            else if (imc > 25 && imc < 29.9)
            {
                Console.Write($"Com {imc:F} de IMC, você está com excesso de peso.");
            }
            else if (imc > 30 && imc < 34.9)
            {
                Console.Write($"Com {imc:F} de IMC, você está com obesidade.");
            }
            else
            {
                Console.Write($"Com {imc:F} de IMC, você está com obesidade mórbida.");
            }
        }
    }
}
