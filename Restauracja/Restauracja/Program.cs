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
            
            Console.WriteLine();

            dania.Sort();
            for (int i = dania.Count - 1; i >= 0; i--)
            {
                dania[i].Info();
            }

            Console.WriteLine();

            // 9a

            Queue<Zamowienie> zamowienia = new Queue<Zamowienie>();
            zamowienia.Enqueue(new Zamowienie(5, 56));
            zamowienia.Enqueue(new Zamowienie(10, 79));
            zamowienia.Enqueue(new Zamowienie(11, 100));
            zamowienia.Enqueue(new Zamowienie(1, 9));
            zamowienia.Enqueue(new Zamowienie(18, 150));
            zamowienia.Enqueue(new Zamowienie(8, 62));
            zamowienia.Enqueue(new Zamowienie(10, 100));

            
            foreach (var obj in zamowienia)
            {
                obj.Rabat();
            }
            Console.WriteLine();

            while (zamowienia.Count > 0)
            {
                Console.WriteLine(zamowienia.Dequeue().ToString());
            }






            Console.ReadKey();

        }


    }
}
