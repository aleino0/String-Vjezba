using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Vjezba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite recenicu:");
            string recenica = Console.ReadLine();
            string[] rijec = recenica.Split(' ');

            Console.WriteLine(rijec.First() + "\n" + rijec.Last());

            Console.ReadKey();
        }
    }
}
