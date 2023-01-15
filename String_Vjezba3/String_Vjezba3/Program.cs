using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Vjezba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi niz znakova:");
            
            string recenica=Console.ReadLine();
            string sVelika = recenica.ToUpper();
            string sMala= recenica.ToLower();
            string sPrvaTri = recenica.Substring(0, 3);
            string sZadnjihPet =recenica.Substring(recenica.Length - 5);
            string s8_11 = recenica.Substring(8, 4);

            Console.WriteLine("Upper: {0} \nLower: {1} \nPrva tri: {2} \nZadnjih pet: {3} \nOd 8.-11.: {4}",
                               sVelika, sMala, sPrvaTri, sZadnjihPet, s8_11);

            Console.ReadKey();
        }
    }
}
