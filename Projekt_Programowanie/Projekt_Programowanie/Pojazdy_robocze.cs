using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie
{
    public class Pojazdy_robocze:Pojazd
    {
        public double Ladownosc;

        public Pojazdy_robocze(double ladownosc, string marka, string model, double rok_Produkcji, double pojemnosc, double moc, string rodzaj_paliwa, double ilosc_miejsc, double masa, double max_masa) : base(marka, model, rok_Produkcji, pojemnosc, moc, rodzaj_paliwa, ilosc_miejsc, masa, max_masa)
        {
            this.Ladownosc = ladownosc;
        }

        public override void wypisz()
        {
            base.wypisz();
            Console.WriteLine("Ładowność "+Ladownosc);
        }
    }
}
