using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luftfahrzeug
{
    class Hubschrauber : Luftfahrzeuge
    {
        public double Rotor { get; set; }

        public new void Starten_verdeckbar()
        {
            Console.WriteLine("Der Hubschrauber startet.");
        }

        public override void Fliegen_abstract()
        {
            Console.WriteLine("Der Hubschrauber fliegt.");
        }

        public new void landen_virtual()
        {
            Console.WriteLine("DEr Hubschrauber landet.");
        }
    }
}
