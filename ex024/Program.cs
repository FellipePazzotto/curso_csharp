namespace ex024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Digite [1] para somar os números.");
            Console.WriteLine("Digite [2] para subtrair os números.");
            Console.WriteLine("Digite [3] para multiplicar os números.");
            Console.WriteLine("Digite [4] para dividir os números.");
            Console.WriteLine("Digite [5] para inserir novos números.");
            Console.WriteLine("Digite [6] para sair do algoritmo.");
            Console.WriteLine("----------------------------------------");

            while(true)
            {
                Console.Write("Digite uma opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        Console.WriteLine("{0} + {1} = {2}.",
                        numero1, numero2, numero1 + numero2);
                        Console.WriteLine("----------------------------------------");
                        break;

                    case 2:
                        Console.WriteLine("{0} - {1} = {2}.",
                        numero1, numero2, numero1 - numero2);
                        Console.WriteLine("----------------------------------------");
                        break;

                    case 3:
                        Console.WriteLine("{0} X {1} = {2}.",
                        numero1, numero2, numero1 * numero2);
                        Console.WriteLine("----------------------------------------");
                        break;

                    case 4:
                        Console.WriteLine("{0} / {1} = {2}.",
                        numero1, numero2, numero1 / numero2);
                        Console.WriteLine("----------------------------------------");
                        break;

                    case 5:
                        Console.WriteLine("----------------------------------------");
                        Console.Write("Digite o primeiro número: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("----------------------------------------");
                        Console.Write("Digite o segundo número: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("----------------------------------------");
                        break;

                    case 6:
                        Console.WriteLine("Pressione a tecla Alt + F4.");
                        Console.WriteLine("----------------------------------------");
                        break;

                    default:
                        Console.WriteLine("Insira uma opção válida.");
                        Console.WriteLine("----------------------------------------");
                        break;
                }
            }
        }
    }
}
