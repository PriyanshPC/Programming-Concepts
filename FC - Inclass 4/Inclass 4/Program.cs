
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass_4
{

    class Program
    {
        static void Main(string[] args)
        {
            int StudentsCount = 0;
            int GradesSum, CountBelowAvg = 0, CountAboveAvg = 0;
            int HighestGrades = 0, CountHighestGrades = 1, LowestGrades = 100, CountLowestGrades = 1;
            Double AvgGrades;

            while (StudentsCount == 0)
            {
                Console.WriteLine("Enter the number of students : ");
                try
                {
                    StudentsCount = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    System.Console.WriteLine("Invalid input, Please try again");
                }
            }
            int[] Grades = new int[StudentsCount];
            int[] StudentsWithLowestGrades = new int[StudentsCount];


            for (int i = 0; i < StudentsCount; i++)
            {
                try
                {

                    Console.WriteLine("Enter the grades for student {0}:   Must be Between 0-100", i + 1);

                    Grades[i] = Convert.ToInt32(Console.ReadLine());
                    if (Grades[i] > 100 || Grades[i] < 0)
                    {
                        i -= 1;
                        Grades[i] = Grades[i] / 0;
                    }

                }
                catch (Exception)
                {
                    // Console.WriteLine(ex.ToString());
                    Console.WriteLine("Please enter valid number between 0-100");
                    i = i - 1;

                }

            }
            GradesSum = Grades.Sum();
            AvgGrades = GradesSum / StudentsCount;                           //AvgGrades =Convert.ToInt32(GradesSum / StudentsCount);
            Console.WriteLine("Average Grades are : {0}", AvgGrades);
            for (int i = 0; i < StudentsCount; i++)
            {

                if (Grades[i] < AvgGrades)
                {
                    CountBelowAvg += 1;
                }
                else
                {
                    CountAboveAvg += 1;
                }
                if (HighestGrades < Grades[i])
                {
                    HighestGrades = Grades[i];
                }
                else if (HighestGrades == Grades[i])
                {
                    CountHighestGrades += 1;
                }
                if (LowestGrades > Grades[i])
                {
                    LowestGrades = Grades[i];
                    StudentsWithLowestGrades[CountLowestGrades - 1] = i;
                }
                else if (LowestGrades == Grades[i])
                {
                    CountLowestGrades += 1;
                    StudentsWithLowestGrades[CountLowestGrades - 1] = i;

                }
            }
            Console.WriteLine("Number of students with Below average Grades is : {0}", CountBelowAvg);
            Console.WriteLine("Number of students with Above average Grades is : {0}", CountAboveAvg);
            Console.WriteLine("Highest Grades are : {0}", HighestGrades);
            Console.WriteLine("Number of students with Highest Grades is : {0}", CountHighestGrades);
            Console.WriteLine("Number of students with Lowest Grades is : {0}", CountLowestGrades);
            Console.WriteLine("Number of students with Lowest Grades are : ");
            Array.Resize(ref StudentsWithLowestGrades, CountLowestGrades);
            Console.Write("       ");
            foreach (var Student in StudentsWithLowestGrades)
            {
                Console.Write("Student No. : {0} , ", Student + 1);
            }

        }

    }
}
