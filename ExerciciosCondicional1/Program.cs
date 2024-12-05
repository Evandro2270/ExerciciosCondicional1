using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                int x = int.Parse(Console.ReadLine());

                if (x < 0)
                {
                    Console.WriteLine("NEGATIVO: ");

                }
                else {
                    Console.WriteLine("NÃO NEGATIVO");
                }
            }
        }
    }
}