using System;
using System.Collections.Generic;
using System.Text;

namespace SharpUR.Lab01
{
    internal class TaskLab04
    {
        public void Run()
        {
            task004();
        }

        private void task004()
        {
            Console.WriteLine("Podawja liczby (gdzie liczba ujemna konczy program):");
            while (true)
            {
                double liczba = inputDouble("Podaj liczbe: ");
                if (liczba < 0)
                {
                    break;
                }
            }
        }
        private double inputDouble(string prompt)
        {
            double liczba;
            while (true)
            {
                Console.WriteLine(prompt);
                if (double.TryParse(Console.ReadLine(), out liczba)) return liczba;
                Console.WriteLine("Bledna wartosc!");
            }
        }
    }
}
