﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Vjezba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica;

            Console.WriteLine("Unesite niz znakova:");
            recenica = Console.ReadLine();

            Console.WriteLine(recenica.Replace(" ", "_"));

            Console.ReadKey();
        }
    }
}
