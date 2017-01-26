using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja
{
    class Zamowienie
    {
        private int ileDan;
        private double suma;

        public Zamowienie(int ileDan, double suma)
        {
            this.ileDan = ileDan;
            this.suma = suma;
        }
        
        public void Rabat()
        {
            if (ileDan > 10) suma = suma - suma / 10;
            ToString();
        }
        
        public override string ToString()
        {
            return "Zamowienie, liczba dan: " + ileDan.ToString() + ", suma: " + suma.ToString();
        }


    }
}
