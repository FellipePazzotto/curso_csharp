using System.Runtime.CompilerServices;

namespace senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "12345"; // senha correta
            string senha_digitada; // senha digitada pelo usuário
            int tentativas = 0; //contador de tentativas
            
            // loop para solicitar uma senha para o usuário
            do
            {
                Console.Clear();
                Console.Write("Digite a senha correta: ");
                senha_digitada = Console.ReadLine();
                tentativas++; // incrementa o contador de tentativas

                // verifica se a senha digitada é diferente da senha correta
                if (senha_digitada != senha && tentativas < 3)
                {
                    Console.WriteLine("Senha incorreta");
                    Console.WriteLine("Você ainda possui {0} tentativa(s).",
                        3 - tentativas);
                    Console.ReadKey();
                }
                else if (senha_digitada != senha && tentativas == 3)
                {
                    Console.WriteLine("Você excedeu as tentativas, acesso bloqueado.");
                    return;
                }
            } while (senha_digitada != senha);

            Console.Clear();
            Console.WriteLine("Você precisou de {0} tentativa(s) para acertar a senha.", 
                tentativas);
        }
    }
}
