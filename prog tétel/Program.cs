using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_tétel
{
    class Program
    {
        static int[] tomb = new int[10] {12, 7, 50, 4, 45, 99, 1, 8, 95, 2};
        
        static void kiir()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0,2}, ",tomb[i]);
            }
            Console.WriteLine();

        }
        static void osszegzes()
        {
            int ossz = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                ossz += tomb[i];
            }
            Console.WriteLine("Összesen: {0}",ossz);
        }
        static void megszam()
        {
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]%3==0)
                {
                    db++;
                }
            }
            Console.WriteLine("3mal osztható számok darabja: {0}",db);
        }
        static void vane()
        {
            int i = 0;
            while (i<tomb.Length && tomb[i]!=69)
            {
                i++;
            }
            if (i<tomb.Length)
            {
                Console.WriteLine("van 69-es szám");
            }
            else
            {
                Console.WriteLine("nincsen 69-es szám");
            }

        }
        static void hol()
        {
            
            int i = 0;
            while (i<tomb.Length && tomb[i]!=50)
            {
                i++;
            }
            Console.WriteLine("50 a {0}. helyen van",i+1);
        }
        static void Main(string[] args)
        {
            kiir();
            osszegzes();
            megszam();
            vane();
            hol();
            Console.ReadKey();
        }
    }
}
