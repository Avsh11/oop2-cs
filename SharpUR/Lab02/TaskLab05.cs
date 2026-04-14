using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SharpUR.Lab02
{
    internal class TaskLab05
    {
        public void Run()
        {
            int[] dane = { 1, 2, 3, 4, 5, 6, 10, 15, 20 };
            Sumator s = new Sumator(dane);

            Console.WriteLine($"Liczba elementow: {s.IleElementow()}");
            Console.WriteLine($"Suma wszystkich elementow: {s.Suma()}");
            Console.WriteLine($"Suma podzielnych przez 2: {s.SumaPodziel2()}");

            Console.WriteLine("Wszystkie elementy:");
            s.WypiszElementy();

            Console.WriteLine("Elementy z zakresu indeksow 2:5:");
            s.WypiszZakres(2, 5);

            Console.WriteLine("Elementy z zakresu z blednymi indeksami (-1:20):");
            s.WypiszZakres(-1, 20);
        }
    }

    public class Sumator
    {
        private int[] Liczby;

        public Sumator(int[] liczby)
        {
            this.Liczby = liczby;
        }

        public int Suma()
        {
            return Liczby.Sum();
        }

        public int SumaPodziel2()
        {
            return Liczby.Where(x => x % 2 == 0).Sum();
        }

        public int IleElementow()
        {
            return Liczby.Length;
        }

        public void WypiszElementy()
        {
            Console.WriteLine(string.Join(", ", Liczby));
        }

        public void WypiszZakres(int lowIndex, int highIndex)
        {
            int start = Math.Max(0, lowIndex);
            int koniec = Math.Min(Liczby.Length - 1, highIndex);

            for (int i = start; i <= koniec; i++)
            {
                Console.Write(Liczby[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
