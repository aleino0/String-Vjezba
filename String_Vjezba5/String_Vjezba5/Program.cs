using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Vjezba5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijeli i decimalni broj odvojene razmakom (Cijeli Decimalini)");
            string[] unos = Console.ReadLine().Split(' ');

            int x = 2 * Convert.ToInt32(unos[0]);
            double y = 2 * Convert.ToDouble(unos[1]);

            Console.WriteLine(x + "\n" + y);

            Console.ReadKey();
        }
    }
}
