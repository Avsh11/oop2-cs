using System;
using System.Collections.Generic;
using System.Text;

namespace SharpUR.Lab02
{
    internal class TaskLab02
    {
        public void Run()
        {
            BankAccount konto = new BankAccount("Jan Kowalski", 1000);
            konto.Wplata(500);
            konto.Wyplata(200);
            Console.WriteLine($"Saldo: {konto.Saldo}");

            Console.WriteLine("\nProba wyplaty 2000:");
            konto.Wyplata(2000);
        }
    }

    public class BankAccount
    {
        private decimal saldo; 
        public string Wlasciciel { get; set; }

        public decimal Saldo
        {
            get { return saldo; }
        }

        public BankAccount(string wlasciciel, decimal poczatkoweSaldo)
        {
            Wlasciciel = wlasciciel;
            saldo = poczatkoweSaldo;
        }

        public void Wplata(decimal kwota)
        {
            if (kwota > 0)
            {
                saldo += kwota;
                Console.WriteLine($"Wplacono {kwota} zl.");
            }
        }

        public void Wyplata(decimal kwota)
        {
            if (kwota > saldo)
            {
                Console.WriteLine("Blad - niewystarczajaca ilosc srodkow na koncie.");
            }
            else if (kwota > 0)
            {
                saldo -= kwota;
                Console.WriteLine($"Wyplacono {kwota} zl.");
            }
        }
    }
}
