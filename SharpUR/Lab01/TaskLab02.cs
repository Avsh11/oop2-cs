using System;
using System.Collections.Generic;
using System.Text;

namespace SharpUR.Lab01
{
    internal class TaskLab02
    {
        public void Run()
        {

        }

        private void task002()
        {
            double[] numbers = new double[10];

            for (int i = 0 < 10; i++)
            {
                numbers[i] = inputDouble($"Podaj liczbę nr {i + 1}:");
            }

            double sum = 0;
            double product = 1; //Iloczyn po ang
            double min = numbers[0];
            double max = numbers[0];

            foreach (double n in numbers)
            {
                sum += n;
                product *= n;
                if (n < min) min = n;
                if (n > max) max = n;
            }

            double average = sum / 10;

            Console.WriteLine("\nWyniki:");
            Console.WriteLine($"Suma: {sum}");
            Console.WriteLine($"Iloczyn: {product}");
            Console.WriteLine($"Średnia: {average:F2}");
            Console.WriteLine($"Wartość minimalna: {min}");
            Console.WriteLine($"Wartość maksymalna: {max}");
        }

        private double inputDouble(string prompt)
        {
            double number;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out number)) return number;
                Console.Write("Błędna wartość. Podaj poprawną liczbę!");
            }
        }
    }
}
