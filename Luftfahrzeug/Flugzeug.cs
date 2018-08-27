using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luftfahrzeug 
{
    class Flugzeug : Luftfahrzeuge
    {
        public double Spannweite { get; set; }

        public new void Starten_verdeckbar()
        {
            Console.WriteLine("Das Flugzeug startet.");
        }

        public override void Fliegen_abstract()
        {
            Console.WriteLine("Das Flugzeug fliegt.");
        }

        public override void landen_virtual()
        {
            Console.WriteLine("Das Flugzeug landet.");
        }
    }

    
}
