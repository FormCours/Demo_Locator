using Demo_Locator.Pattern.Locator;
using Demo_Locator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Locator
{
    class Program
    {
        static void Main(string[] args)
        {
            //NicoService ns1 = new NicoService();
            //NicoService ns2 = (NicoService) Activator.CreateInstance(typeof(NicoService));

            //ns1.AfficherSapin();
            //ns2.AfficherSapin();


            ServiceLocator locator = ServiceLocator.Default;

            locator.Service1().AfficherLorem();
            Console.WriteLine();
            locator.Service2().AfficherBoisson();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
