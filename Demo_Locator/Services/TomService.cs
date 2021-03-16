using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Locator.Services
{
    public class TomService
    {
        public string Idee { get; set; }

        public TomService(string idee)
        {
            Idee = idee;
        }

        public void AfficheIdee()
        {
            Console.WriteLine($"L'idée est {Idee}");
        }
    }
}
