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
            Koira ko = new Koira();
            ko.name = "Max";
            Console.WriteLine(ko.palautaKoirannimi());
            Console.WriteLine("===========================");
            
            ko.asetaKoirannimi("musti");
            Console.WriteLine(ko.palautaKoirannimi());

            Console.ReadKey();
        }
    }
}
