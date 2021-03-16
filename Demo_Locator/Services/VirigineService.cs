using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Locator.Services
{
    public class VirigineService
    {
        public string Boisson { get; set; }

        public VirigineService()
        {
            Boisson = "Eau";
        }
        public VirigineService(string boisson)
        {
            Boisson = boisson;
        }

        public void AfficherBoisson()
        {
            Console.WriteLine($"Voci votre {Boisson}");
        }
    }
}
