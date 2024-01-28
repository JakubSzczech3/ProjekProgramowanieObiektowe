using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie
{
    public class Ciezarowka : Pojazdy_robocze
    {
        public string Rodzaj_ciezarowki;
        public Ciezarowka(string rodzaj_ciezarowki,double ladownosc, string marka, string model, double rok_Produkcji, double pojemnosc, double moc, string rodzaj_paliwa, double ilosc_miejsc, double masa, double max_masa) : base(ladownosc, marka, model, rok_Produkcji, pojemnosc, moc, rodzaj_paliwa, ilosc_miejsc, masa, max_masa)
        {
            this.Rodzaj_ciezarowki = rodzaj_ciezarowki;
        }
        public override void wypisz()
        {
            base.wypisz();
            Console.WriteLine("Rodzaj ciężarówki "+Rodzaj_ciezarowki);
        }
    }
}
