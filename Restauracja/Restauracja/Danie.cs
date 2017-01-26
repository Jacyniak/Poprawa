using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja
{
    abstract class Danie : IComparable<Danie>
    {
        protected string nazwa;
        protected double cena;

        public Danie(string nazwa, double cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            Info();
        }

        public virtual void Info()
        {
            Console.WriteLine("Danie, nazwa: " + nazwa + ", cena: " + cena + ".");
        }

        public int CompareTo(Danie other)
        {
            if (this.cena >= other.cena) return other.nazwa.CompareTo(this.nazwa);
            else return this.cena.CompareTo(other.cena);
        }
        
    }
}
