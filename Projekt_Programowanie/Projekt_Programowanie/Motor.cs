using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie
{
    public class Motor : Pojazd
    {
        public Motor(string marka, string model, double rok_Produkcji, double pojemnosc, double moc, string rodzaj_paliwa, double ilosc_miejsc,double masa, double max_masa) : base(marka, model, rok_Produkcji, pojemnosc, moc, rodzaj_paliwa, ilosc_miejsc, masa, max_masa)
        {
            this.Max_Masa = 1000;
        }
        public void Wypisz()
        {
            Console.WriteLine(Marka);
            Console.WriteLine(Model);
            Console.WriteLine(Rok_Produkcji);
            Console.WriteLine(Pojemnosc);
            Console.WriteLine(Moc);
            Console.WriteLine(Rodzaj_paliwa);
            Console.WriteLine(Ilosc_miejsc);
            Console.WriteLine(Masa);
            Console.WriteLine(Max_Masa);
        }

        public override void wypisz()
        {
            base.wypisz();
        }
    }
}
