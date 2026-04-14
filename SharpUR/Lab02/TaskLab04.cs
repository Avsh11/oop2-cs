using System;
using System.Collections.Generic;
using System.Text;

namespace SharpUR.Lab02
{
    internal class TaskLab04
    {
        public void Run()
        {
            Licz l1 = new Licz(10);
            Licz l2 = new Licz(50);

            l1.Dodaj(5);
            l1.WypiszStan(); 

            l2.Odejmij(20);
            l2.WypiszStan(); 
        }
    }

    public class Licz
    {
        private double value;
        public Licz(double initialValue)
        {
            this.value = initialValue;
        }

        public void Dodaj(double liczba)
        {
            value += liczba;
        }

        public void Odejmij(double liczba)
        {
            value -= liczba;
        }

        public void WypiszStan()
        {
            Console.WriteLine($"Aktualna wartosc pola value: {value}");
        }
    }
}
