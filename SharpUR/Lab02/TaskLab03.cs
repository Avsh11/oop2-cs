using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace SharpUR.Lab02
{
    internal class TaskLab03
    {
        public void Run()
        {
            Student student = new Student("Joe", "Biden");
            student.DodajOcene(5);
            student.DodajOcene(4);
            student.DodajOcene(3);

            Console.WriteLine($"Student: {student.Imie} {student.Nazwisko}");
            Console.WriteLine($"Srednia ocen: {student.SredniaOcen:F2}");
        }
    }

    public class Student
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        private List<int> oceny = new List<int>();

        public double SredniaOcen
        {
            get
            {
                if (oceny.Count == 0) return 0;
                return oceny.Average();
            }
        }

        public Student(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }
        public void DodajOcene(int ocena)
        {
            oceny.Add(ocena);
            Console.WriteLine($"Dodano ocene: {ocena}");
        }
    }
}
