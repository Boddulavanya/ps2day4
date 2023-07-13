using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a rectangular array to store roll numbers and marks
            int[,] studmarks = new int[4, 5]
            {
            { 1, 80, 85, 90, 95 },
            { 2, 75, 70, 85, 80 },
            { 3, 90, 92, 88, 95 },
            { 4, 70, 65, 75, 80 }
            };

            // Printing the header
            Console.WriteLine("RollNo sem1 sem2 sem3 sem4 Total");

            // Printing the details for each student
            for (int i = 0; i < 4; i++)
            {
                int rollNo = studmarks[i, 0];
                int sem1 = studmarks[i, 1];
                int sem2 = studmarks[i, 2];
                int sem3 = studmarks[i, 3];
                int sem4 = studmarks[i, 4];
                int total = sem1 + sem2 + sem3 + sem4;

                // Printing the details
                Console.WriteLine($"{rollNo,-6} {sem1,-5} {sem2,-5} {sem3,-5} {sem4,-5} {total,-5}");
            }

            Console.ReadKey();
        }
    }
}
