using System;

namespace Inclass3
{
    class Program
    {
        //Priyansh Chaudhary and Wisam Moussa//
        static double SalaryUpdate(double presalary, double rate)
        {
            double upsalary = presalary * (100 + rate) / 100;
            return upsalary;
        }
        static double PerimeterShape(double side1)
        {
            double perimeter = side1 * 4;
            return perimeter;
        }
        static double PerimeterShape(double side1, double side2)
        {
            double perimeter = 2 * (side1 + side2);
            return perimeter;
        }
        static double PerimeterShape(double side1, double side2, double side3)
        {
            double perimeter = side1 + side2 + side3;
            return perimeter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Please enter your Initials");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter you previous salary");
            double presalary = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the rate in %");
            double rate = double.Parse(Console.ReadLine());

            double latestsalary = SalaryUpdate(presalary, rate);
            Console.WriteLine("The employee " +name +" will have the current salary of " + presalary+ " increased to " + latestsalary);



            //***********************************
            Console.WriteLine("2. Please select between these three options and enter the number associated to them: Square(1) , Rectangle(2) , Triangle(3)");
            double shape = double.Parse(Console.ReadLine());
            double Perimeter, r1, r2, t1, t2, t3;
            if (shape == 1)
            {
                Console.WriteLine("Please enter the length");
                Perimeter = PerimeterShape(double.Parse(Console.ReadLine()));
                Console.WriteLine("The perimeter of  the selected shape is " + Perimeter);
            }
            else if (shape == 2)
            {
                Console.WriteLine("Please enter the length");
                r1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the width");
                r2 = double.Parse(Console.ReadLine());
                Perimeter = PerimeterShape(r1, r2);
                Console.WriteLine("The perimeter of  the selected shape is " + Perimeter);
            }
            else if (shape == 3)
            {
                Console.WriteLine("Please enter Side 1");
                t1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter Side 2");
                t2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter Side 3");
                t3 = double.Parse(Console.ReadLine());
                Perimeter = PerimeterShape(t1, t2, t3);
                Console.WriteLine("The perimeter of  the selected shape is " + Perimeter);
            }
            else
            {
                Console.WriteLine("You did not enter 1 or 2 or even 3.. try again... ");
            }
        }
    }
}
