using System;
using System.Collections.Generic;
using System.Text;

namespace SharpUR.Lab01
{
    internal class TaskLab05
    {
        public void Run()
        {
            task005();
        }

        private void task005()
        {
            int n = (int)inputDouble("Ile liczb posortowac? ");
            double[] tablica = new double[n];

            for (int i = 0; i < n; i++)
            {
                tablica[i] = inputDouble($"Podaj liczbe {i + 1}: ");
            }

            // sortowanie babelkowe
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        double temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Wynik sortowania:");
            foreach (double liczba in tablica) Console.Write(liczba + " ");
            Console.WriteLine();
        }

        private double inputDouble(string prompt)
        {
            double liczba;
            while (true)
            {
                Console.WriteLine(prompt);
                if (double.TryParse(Console.ReadLine(), out liczba)) return liczba;
                Console.WriteLine("Bledna warosc!");
            }
        }
    }
}
