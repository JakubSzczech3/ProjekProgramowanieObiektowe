using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie
{
    public abstract class Pojazd
    {
        public string Marka;
        public string Model;
        public double Rok_Produkcji;
        public double Pojemnosc;
        public double Moc;
        public string Rodzaj_paliwa;
        public double Ilosc_miejsc;
        public double Masa;
        public double Max_Masa;

        public Pojazd(string marka, string model, double rok_Produkcji, double pojemnosc, double moc, string rodzaj_paliwa, double ilosc_miejsc, double masa, double max_Masa)
        {
            this.Marka = marka;
            this.Model = model;
            this.Rok_Produkcji = rok_Produkcji;
            this.Pojemnosc = pojemnosc;
            this.Moc = moc;
            this.Rodzaj_paliwa = rodzaj_paliwa;
            this.Ilosc_miejsc = ilosc_miejsc;
            this.Masa = masa;
            this.Max_Masa = max_Masa;

        }
        public virtual void wypisz() {
            Console.WriteLine("Marka "+Marka);
            Console.WriteLine("Model "+Model);
            Console.WriteLine("Rok Produkcji "+Rok_Produkcji);
            Console.WriteLine("Pojemność "+Pojemnosc);
            Console.WriteLine("Moc "+Moc);
            Console.WriteLine("Rodzaj paliwa "+Rodzaj_paliwa);
            Console.WriteLine("Ilość miejsc "+Ilosc_miejsc);
            Console.WriteLine("Masa "+Masa);
            Console.WriteLine("Maksymalna masa "+Max_Masa);
        }
    }
}
