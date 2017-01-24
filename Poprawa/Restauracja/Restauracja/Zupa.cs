using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja
{
    class Zupa : Danie
    {
        public Zupa(string nazwa, double cena)
            :base(nazwa, cena)
        {

        }
        public override void Info()
        {
            Console.WriteLine( "Zupa:" + Environment.NewLine +"Danie, nazwa: " + nazwa + ", cena: " + cena + ".");
        }
    }
}
