using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luftfahrzeug
{
    class Program
    {
        static void Main(string[] args)
        {
            Flugzeug Flieger_1 = new Flugzeug();
            Hubschrauber Hubschrauber_1 = new Hubschrauber();
            Segelflieger Segelflieger_1 = new Segelflieger();

            Flieger_1.Starten_verdeckbar();
            Flieger_1.Fliegen_abstract();
            Flieger_1.landen_virtual();

            Hubschrauber_1.Starten_verdeckbar();
            Hubschrauber_1.Fliegen_abstract();
            Hubschrauber_1.landen_virtual();

            Segelflieger_1.Starten_verdeckbar();
            Segelflieger_1.Fliegen_abstract();
            Segelflieger_1.landen_virtual();


            DoSomething(Flieger_1);
            DoSomething(Hubschrauber_1);
            DoSomething(Segelflieger_1);

            Console.WriteLine("\n\nJetzt Polymorph\n\n");

            Luftfahrzeuge Flieger_2 = new Flugzeug();
            Luftfahrzeuge Hubschrauber_2 = new Hubschrauber();
            Luftfahrzeuge Segelflieger_2 = new Segelflieger();

            Flieger_2.Starten_verdeckbar();
            Flieger_2.Fliegen_abstract();
            Flieger_2.landen_virtual();

            Hubschrauber_2.Starten_verdeckbar();
            Hubschrauber_2.Fliegen_abstract();
            Hubschrauber_2.landen_virtual();

            Segelflieger_2.Starten_verdeckbar();
            Segelflieger_2.Fliegen_abstract();
            Segelflieger_2.landen_virtual();


            DoSomething(Flieger_2);
            DoSomething(Hubschrauber_2);
            DoSomething(Segelflieger_2);

            Console.ReadLine();
        }

        static public void DoSomething(Luftfahrzeuge lfzg)
        {
            if (lfzg != null)
            {
                if (lfzg is Flugzeug)
                    Console.WriteLine("Spannweite: ", ((Flugzeug)lfzg).Spannweite);
                else if (lfzg is Hubschrauber)
                    Console.WriteLine("Rotor: ", ((Hubschrauber)lfzg).Rotor);
                else if (lfzg is Segelflieger)
                    Console.WriteLine("Das ist ein Segelflieger");
                else
                    Console.WriteLine("Unbekannter Typ.");
            }
        }


    }
}
