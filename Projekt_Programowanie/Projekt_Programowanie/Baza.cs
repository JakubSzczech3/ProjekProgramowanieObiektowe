using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie
{
    public class Baza
    {
        public List<Bus> bus = new List<Bus>();
        public List<Pojazdy_specialistyczne> pspec = new List<Pojazdy_specialistyczne>();
        public List<Ciezarowka> ciezarowka = new List<Ciezarowka>();
        public List<Motor> motor = new List<Motor>();
        public List<Samochod> samochod = new List<Samochod>();

        public Baza(List<Bus> bus, List<Pojazdy_specialistyczne> pspec, List<Ciezarowka> ciezarowka, List<Motor> motor, List<Samochod> samochod)
        {
            this.bus = bus;
            this.pspec = pspec;
            this.ciezarowka = ciezarowka;
            this.motor = motor;
            this.samochod = samochod;
        }

        public void dodawanieBus()
        {
            try
            {
                Console.WriteLine("Podaj rodzaj busa");
                string rodzaj_busa = Console.ReadLine();
                Console.WriteLine("Podaj łądowność busa");
                double ladownosc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj marke busa");
                string marka = Console.ReadLine();
                Console.WriteLine("Podaj model busa");
                string model = Console.ReadLine();
                Console.WriteLine("Podaj rok produkcji busa");
                double rok_Produkcji = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj pojemnosc busa");
                double pojemnosc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj moc busa");
                double moc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj rodzaj paliwa busa");
                string rodzaj_paliwa = Console.ReadLine();
                Console.WriteLine("Podaj ilosc miejsc w busie");
                double ilosc_miejsc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj masę busa");
                double masa = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj maksymalną masę busa");
                double max_masa = Convert.ToDouble(Console.ReadLine());
                bus.Add(new Bus(rodzaj_busa, ladownosc, marka, model, rok_Produkcji, pojemnosc, moc, rodzaj_paliwa, ilosc_miejsc, masa, max_masa));
                zapisz();
                Menu();
            }

            catch (System.FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("Podaj poprawne dane");
                dodawanieBus();
            }
        }
        public void dodawaniePSPEC()
        {
            try
            {
                Console.WriteLine("Podaj rodzaj Pojazdu");
                string zastosowanie = Console.ReadLine();
                Console.WriteLine("Podaj ładowność pojazdu");
                double ladownosc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj marke pojazdu");
                string marka = Console.ReadLine();
                Console.WriteLine("Podaj model pojazdu");
                string model = Console.ReadLine();
                Console.WriteLine("Podaj rok produkcji pojazdu");
                double rok_Produkcji = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj pojemnosc pojazdu");
                double pojemnosc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj moc pojazdu");
                double moc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj rodzaj paliwa");
                string rodzaj_paliwa = Console.ReadLine();
                Console.WriteLine("Podaj ilosc miejsc w pojezdzie");
                double ilosc_miejsc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj masę pojazdu");
                double masa = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj maksymalną masę pojazdu");
                double max_masa = Convert.ToDouble(Console.ReadLine());
                pspec.Add(new Pojazdy_specialistyczne(zastosowanie, ladownosc, marka, model, rok_Produkcji, pojemnosc, moc, rodzaj_paliwa, ilosc_miejsc, masa, max_masa));
                zapisz();
                Menu();
            }

            catch (System.FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("Podaj poprawne dane");
                dodawaniePSPEC();
            }
        }
        public void dodawanieCiezarowka()
        {
            try
            {
                Console.WriteLine("Podaj rodzaj Ciezarowki");
                string rodzaj_ciezarowki = Console.ReadLine();
                Console.WriteLine("Podaj ładowność ciezarowki");
                double ladownosc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj marke ciezarowki");
                string marka = Console.ReadLine();
                Console.WriteLine("Podaj model ciezarowki");
                string model = Console.ReadLine();
                Console.WriteLine("Podaj rok produkcji ciezarowki");
                double rok_Produkcji = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj pojemnosc ciezarowki");
                double pojemnosc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj moc ciezarowki");
                double moc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj rodzaj paliwa");
                string rodzaj_paliwa = Console.ReadLine();
                Console.WriteLine("Podaj ilosc miejsc w ciezarowce");
                double ilosc_miejsc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj masę ciezarowki");
                double masa = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj maksymalną masę pojazdu");
                double max_masa = Convert.ToDouble(Console.ReadLine());
                ciezarowka.Add(new Ciezarowka(rodzaj_ciezarowki, ladownosc, marka, model, rok_Produkcji, pojemnosc, moc, rodzaj_paliwa, ilosc_miejsc, masa, max_masa));
                zapisz();
                Menu();
            }

            catch (System.FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("Podaj poprawne dane");
                dodawanieCiezarowka();
            }
        }
        public void dodawanieMotor()
        {
            try
            {
                Console.WriteLine("Podaj marke motocykla");
                string marka = Console.ReadLine();
                Console.WriteLine("Podaj model Motocykla");
                string model = Console.ReadLine();
                Console.WriteLine("Podaj rok produkcji motocykla");
                double rok_Produkcji = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj pojemnosc motocykla");
                double pojemnosc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj moc motocykla");
                double moc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj rodzaj paliwa");
                string rodzaj_paliwa = Console.ReadLine();
                Console.WriteLine("Podaj ilosc miejsc motocykla");
                double ilosc_miejsc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj masę motocykla");
                double masa = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj maksymalną masę pojazdu");
                double max_masa = Convert.ToDouble(Console.ReadLine());
                motor.Add(new Motor(marka, model, rok_Produkcji, pojemnosc, moc, rodzaj_paliwa, ilosc_miejsc, masa, max_masa));
                zapisz();
                Menu();
            }

            catch (System.FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("Podaj poprawne dane");
                dodawanieMotor();
            }
        }
        public void dodawanieSamochod()
        {
            try
            {
                Console.WriteLine("Podaj marke sanochodu");
                string marka = Console.ReadLine();
                Console.WriteLine("Podaj model samochodu");
                string model = Console.ReadLine();
                Console.WriteLine("Podaj rok produkcji samochodu");
                double rok_Produkcji = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj pojemnosc samochodu");
                double pojemnosc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj moc samochodu");
                double moc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj rodzaj paliwa");
                string rodzaj_paliwa = Console.ReadLine();
                Console.WriteLine("Podaj ilosc miejsc w samochodzie");
                double ilosc_miejsc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj masę samochodu");
                double masa = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj maksymalną masę pojazdu");
                double max_masa = Convert.ToDouble(Console.ReadLine());
                samochod.Add(new Samochod(marka, model, rok_Produkcji, pojemnosc, moc, rodzaj_paliwa, ilosc_miejsc, masa, max_masa));
                zapisz();
                Menu();
            }

            catch (System.FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("Podaj poprawne dane");
                dodawanieSamochod();
            }
        }
        public void wypisywanie() {
            Console.Clear();
            Console.WriteLine("Wybierz numer listy którą wypisać: ");
            Console.WriteLine("1.BUS");
            Console.WriteLine("2.CIĘŻARÓWKI");
            Console.WriteLine("3.MOTOCUKLE");
            Console.WriteLine("4.POJAZDY SPECIALISTYCZNE");
            Console.WriteLine("5.SAMOCHODY");
            Console.WriteLine("6.MENU");
            int numer = Convert.ToInt32(Console.ReadLine());
            if (numer > 6 || numer < 1) {
                Console.Clear();
                Console.WriteLine("Wybierz POPRAWNY numer z listy");
                wypisywanie();
            };
            switch (numer)
            {
                case 1:
                    Console.Clear();
                    for (int i = 0; i < bus.Count; i++) {

                        Console.WriteLine("ID: " + i);
                        bus[i].wypisz();

                    }
                    Console.WriteLine("Naciśnij enter aby powrócić do wyboru kategori");
                    Console.ReadKey();
                    Console.Clear();
                    wypisywanie();

                    break;
                case 2:
                    Console.Clear();
                    for (int i = 0; i < ciezarowka.Count; i++)
                    {

                        Console.WriteLine("ID: " + i);
                        ciezarowka[i].wypisz();

                    }
                    Console.WriteLine("Naciśnij enter aby powrócić do wyboru kategori");
                    Console.ReadKey();
                    Console.Clear();
                    wypisywanie();

                    break;
                case 3:
                    Console.Clear();
                    for (int i = 0; i < motor.Count; i++)
                    {

                        Console.WriteLine("ID: " + i);
                        motor[i].wypisz();

                    }
                    Console.WriteLine("Naciśnij enter aby powrócić do wyboru kategori");
                    Console.ReadKey();
                    Console.Clear();
                    wypisywanie();

                    break;
                case 4:
                    Console.Clear();
                    for (int i = 0; i < pspec.Count; i++)
                    {

                        Console.WriteLine("ID: " + i);
                        pspec[i].wypisz();

                    }
                    Console.WriteLine("Naciśnij enter aby powrócić do wyboru kategori");
                    Console.ReadKey();
                    Console.Clear();
                    wypisywanie();

                    break;
                case 5:
                    Console.Clear();
                    for (int i = 0; i < samochod.Count; i++)
                    {

                        Console.WriteLine("ID: " + i);
                        samochod[i].wypisz();

                    }
                    Console.WriteLine("Naciśnij enter aby powrócić do wyboru kategori");
                    Console.ReadKey();
                    Console.Clear();
                    wypisywanie();

                    break;
                case 6:
                    Menu();

                    break;

            }

        }
        public void usuwanie() {
            Console.Clear();
            Console.WriteLine("Wybierz numer listy z której chcesz usuwać: ");
            Console.WriteLine("1.BUS");
            Console.WriteLine("2.CIĘŻARÓWKI");
            Console.WriteLine("3.MOTOCUKLE");
            Console.WriteLine("4.POJAZDY SPECIALISTYCZNE");
            Console.WriteLine("5.SAMOCHODY");
            Console.WriteLine("6.MENU");
            int numerl = Convert.ToInt32(Console.ReadLine());
            if (numerl > 6 || numerl < 1)
            {
                Console.Clear();
                Console.WriteLine("Wybierz POPRAWNY numer z listy");
                usuwanie();

            };
            switch (numerl)
            {
                case 1: 
                    Console.WriteLine("Wybierz numer ID elementu który chcesz usunąć");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    bus.RemoveAt(id1);
                    zapisz();
                    Menu();
                    break;
                case 2:
                    Console.WriteLine("Wybierz numer ID elementu który chcesz usunąć");
                    int id2 = Convert.ToInt32(Console.ReadLine());
                    ciezarowka.RemoveAt(id2);
                    zapisz();
                    Menu();
                    break;
                case 3:
                    Console.WriteLine("Wybierz numer ID elementu który chcesz usunąć");
                    int id3 = Convert.ToInt32(Console.ReadLine());
                    motor.RemoveAt(id3);
                    zapisz();
                    Menu();
                    break;
                case 4:
                    Console.WriteLine("Wybierz numer ID elementu który chcesz usunąć");
                    int id4 = Convert.ToInt32(Console.ReadLine());
                    pspec.RemoveAt(id4);
                    zapisz();
                    Menu();
                    break;
                case 5:
                    Console.WriteLine("Wybierz numer ID elementu który chcesz usunąć");
                    int id5 = Convert.ToInt32(Console.ReadLine());
                    samochod.RemoveAt(id5);
                    zapisz();
                    Menu();
                    break;
                case 6:
                    Menu();
                    break;
            }
        }
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1.Wypisz dane z bazy");
            Console.WriteLine("2.Dodaj dane do bazy");
            Console.WriteLine("3.Usuń dane z bazy");
            int opcja = Convert.ToInt32(Console.ReadLine()); 
            if ( opcja > 3 ) { Menu(); }
            switch (opcja)
            {
                case 1:
                    wypisywanie();

                    break;
                case 2:
                    dodawanie();

                    break; 
                case 3:
                    usuwanie();

                    break;
            }

        }
        public void dodawanie() {
            Console.Clear();
            Console.WriteLine("Wybierz numer listy do której chcesz dodać: ");
            Console.WriteLine("1.BUS");
            Console.WriteLine("2.CIĘŻARÓWKI");
            Console.WriteLine("3.MOTOCUKLE");
            Console.WriteLine("4.POJAZDY SPECIALISTYCZNE");
            Console.WriteLine("5.SAMOCHODY");
            Console.WriteLine("6.MENU");

            int numer2 = Convert.ToInt32(Console.ReadLine());
            if (numer2 > 6 || numer2 < 1)
            {
                Console.Clear();
                Console.WriteLine("Wybierz POPRAWNY numer z listy");
                dodawanie();
            }
            switch (numer2)
            {
                case 1:
                    dodawanieBus();

                    break;
                case 2:
                    dodawanieCiezarowka();

                    break;
                case 3:
                    dodawanieMotor();

                    break;
                case 4:
                    dodawaniePSPEC();

                    break;
                case 5:
                    dodawanieSamochod();
 
                    break;
                case 6:
                    Menu();

                    break;
            }

        }
        public void zapisz() {
            String BazaDanych = JsonConvert.SerializeObject(this);
            File.WriteAllText("BazaDanych.json", BazaDanych);

        }
    }
}

