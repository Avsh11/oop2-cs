using System;
using System.Collections.Generic;
using System.Text;

namespace SharpUR.Lab01
{
    internal class TaskLab01
    {
        public void Run()
        {
            task001();
        }

        private void task001()
        {
            Console.WriteLine("Rozwiązanie równania kwadratowego ax^2+bx+c = 0");

            double a = inputDouble("Podaj współczynnik a: ");
            double b = inputDouble("Podaj współczynnik b: ");
            double c = inputDouble("Podaj współczynnik c: ");

            if (a == 0) { Console.WriteLine("To nie jest równanie kwadratowe!. "); return; }
            double delta = Math.Pow(b, 2) - (4 * a * c);
            if (delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + -Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Równanie ma dwa pierwiastki rzeczywiste: ");
                Console.WriteLine($"x1 = {x1:F2}, x2 = {x2:F2}");
            }
            else if (delta == 0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine("Jedno rozwiązanie:  + {x1:F2}");
            }
            else
            {
                Console.WriteLine("Brak rozwiązania w zbiore liczb rzeczywistych.");
            }
        }

        /// <summary>
        /// Metoda pobierająca dane od usera typu string i konwertująca dane na double. 
        /// Metoda wymusza na użytkownikowi poprawne podane liczby
        /// </summary>
        /// <param name="prompt">Tekst który będzie wyświetlony userowi</param>
        /// <returns>Zwraca liczbę typu double</returns>
        private double inputDouble(string prompt)
        {
            double liczba;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out liczba))
                {
                    return liczba;
                }
                Console.WriteLine("Błędna wartość. Podaj poprawną liczbę!");
            }
        }
    }
}
