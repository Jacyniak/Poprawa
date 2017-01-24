using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja
{
    class DanieGlowne : Danie
    {
        public DanieGlowne(string nazwa, double cena)
            :base(nazwa, cena)
        {

        }
        public override void Info()
        {
            Console.WriteLine( "Danie glowne:" + Environment.NewLine +"Danie, nazwa: " + nazwa + ", cena: " + cena + ".");
        }
    }
}
