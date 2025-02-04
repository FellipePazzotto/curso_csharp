namespace contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número inicial: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número final: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a razão para percorrer o intervalo: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------");

            Contagem(x, y, z);
        }

        static void Contagem(int inicio, int fim, int razao)
        {
            if(razao < 0)
            {
                razao *= -1;
            }

            if(razao == 0)
            {
                Console.WriteLine("Digite uma razão diferente de zero!!");
            }
            else if (inicio < fim)
            {
                int cont = inicio;
                while (cont <= fim)
                {
                    Console.Write($"{cont}, ");
                    Thread.Sleep(500);
                    cont += razao;
                }

                Console.WriteLine("e fim!!");
            }
            else
            {
                int cont = inicio;
                while (cont >= fim)
                {
                    Console.Write($"{cont}, ");
                    Thread.Sleep(500);
                    cont -= razao;
                }

                Console.WriteLine("e fim!!");
            }
        }
    }
}
