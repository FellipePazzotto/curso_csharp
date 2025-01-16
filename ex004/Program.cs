namespace ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");

            Console.WriteLine("{0} X 01 = {1}", numero, numero * 1);
            Console.WriteLine("{0} X 02 = {1}", numero, numero * 2);
            Console.WriteLine("{0} X 03 = {1}", numero, numero * 3);
            Console.WriteLine("{0} X 04 = {1}", numero, numero * 4);
            Console.WriteLine("{0} X 05 = {1}", numero, numero * 5);
            Console.WriteLine("{0} X 06 = {1}", numero, numero * 6);
            Console.WriteLine("{0} X 07 = {1}", numero, numero * 7);
            Console.WriteLine("{0} X 08 = {1}", numero, numero * 8);
            Console.WriteLine("{0} X 09 = {1}", numero, numero * 9);
            Console.WriteLine("{0} X 10 = {1}", numero, numero * 10);
        }
    }
}
