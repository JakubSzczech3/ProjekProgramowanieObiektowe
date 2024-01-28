using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie
{
    public class Bus : Pojazdy_robocze
    {
        public string Rodzaj_busa;
        public Bus(string rodzaj_busa,double ladownosc, string marka, string model, double rok_Produkcji, double pojemnosc, double moc, string rodzaj_paliwa, double ilosc_miejsc, double masa, double max_masa) : base(ladownosc, marka, model, rok_Produkcji, pojemnosc, moc, rodzaj_paliwa, ilosc_miejsc, masa, max_masa)
        {
            this.Rodzaj_busa = rodzaj_busa;
        }
        public override void wypisz()
        {
            base.wypisz();
            Console.WriteLine("Rodzaj busa "+Rodzaj_busa);
        }
    }
}
