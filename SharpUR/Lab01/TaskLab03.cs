using System;
using System.Collections.Generic;
using System.Text;

namespace SharpUR.Lab01
{
    internal class TaskLab03
    {
        public void Run()
        {
            task003();
        }

        private void task003()
        {
            Console.WriteLine("Liczby od 20 do 0 z wylaczeniem liczb {2,6,9,15,19}:");
            for (int i = 20; i >= 0; i--)
            {
                if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
