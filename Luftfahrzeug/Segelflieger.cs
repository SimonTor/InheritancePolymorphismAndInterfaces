using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luftfahrzeug
{
    class Segelflieger : Flugzeug
    {
        public override void Fliegen_abstract()
        {
            Console.WriteLine("Der Segelflieger fliegt.");
        }

        public new void landen_virtual()
        {
            Console.WriteLine("Das Segelflugzeug lander.");
        }
    }
}
