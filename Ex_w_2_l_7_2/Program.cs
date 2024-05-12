using System.ComponentModel.Design;

namespace W_2_l_7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj liczbe");
            a = int.Parse(Console.ReadLine());

            if ((a % 2) == 0) {
                Console.WriteLine(a + " Liczba parzysta");
            }
            else
            { Console.WriteLine(a + " Liczba nieparzysta"); }
        }
    }
}
