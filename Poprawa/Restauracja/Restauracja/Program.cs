using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Danie> dania = new List<Danie>();
            dania.Add(new DanieGlowne("schabowy", 5));
            dania.Add(new Zupa("ogorkowa", 8));
            dania.Add(new Zupa("pomidorowa", 6));
            dania.Add(new DanieGlowne("ziemniaki", 2));
            dania.Add(new DanieGlowne("surowka", 3));
            
            dania.Sort();
            for (int i = dania.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(dania[i].ToString());
            }

            foreach (Object obj in dania)
            {
                //Info();
            }



            Console.ReadKey();


        }


    }
}
