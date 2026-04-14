using System;
using System.Collections.Generic;
using System.Text;

namespace SharpUR.Lab02
{
    internal class TaskLab01
    {
        public void Run()
        {
            try
            {
                Osoba osoba = new Osoba("Jan", "Kowalski", 30);
                osoba.WyswietlInformacje();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Blad: {e.Message}");
            }
        }
    }
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;

        public string Imie
        {
            get => imie;
            set
            {
                if (value.Length < 2) throw new ArgumentException("Imie mam iec min 2 znaki!");
                imie = value;
            }
        }

        public string Nazwisko
        {
            get => nazwisko;
            set
            {
                if (value.Length < 2) throw new ArgumentException("Nazwisko ma miec min 2 znaki!");
                nazwisko = value;
            }
        }

        public int Wiek
        {
            get => wiek;
            set
            {
                if (value <= 0) throw new ArgumentException("Wiek musi byc dodatni!");
                wiek = value;
            }
        }

        public Osoba(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Osoba: {Imie} {Nazwisko}, Wiek: {Wiek}");
        }
    }
}
