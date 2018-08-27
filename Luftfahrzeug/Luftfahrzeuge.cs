using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luftfahrzeug
{
    public abstract class Luftfahrzeuge
    {
        public string Hersteller { get; set; }
        public int Baujahr { get; set; }

        public void Starten_verdeckbar()
        {
            Console.WriteLine("Das Luftfahrzeug startet.");
        }

        public abstract void Fliegen_abstract();

        public virtual void landen_virtual()
        {
            Console.WriteLine("Das Luftfahrzeug lander.");
        }
    }
}
