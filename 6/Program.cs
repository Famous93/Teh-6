using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elainluokat
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) 
            {
                Koira ko = new Koira();
                Kissa ki = new Kissa();
               

                Random k = new Random();
                ko.asetaKoiranikä(k.Next(1,15));
                ki.asetakissanikä(k.Next(1,10));

                Console.WriteLine($"Koira on: {ko.palautaKoiranikä()} vuotta");
                Console.WriteLine($"Kissa on: {ki.palautakissanikä()} vuotta");

                if( ko.palautaKoiranikä() < ki.palautakissanikä())
                {
                    Console.WriteLine("Kissa on vanhempi");
                }
                else
                {
                    Console.WriteLine("Koira on vanhempi");
                }
                Console.WriteLine("\n====================== \n");
                Console.ReadKey();
            }

        }
    }
}
