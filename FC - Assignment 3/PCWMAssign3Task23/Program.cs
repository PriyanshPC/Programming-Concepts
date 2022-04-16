using System;

namespace PCWMAssign3Task23
{
    class Program
    {

        static int YearsForecast(int popA, int popB, float rateA, float rateB)
        {
            Double YearsD = Math.Log(popA / popB) / (Math.Log(100 + rateA) - Math.Log(100 + rateB));
            int Years = Convert.ToInt32(YearsD);
            if (Years < YearsD)
            {
                Years = Years + 1;
            }
            return Years;
        }


        static void Main(string[] args)
        {
            int greaterP;
            int smallerP;
            float greaterR;
            float smallerR;
            do
            {
                Console.WriteLine("Enter population A :");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter population B :");
                int B = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter population A growth rate per year:");
                float GA = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter population B growth rate per year :");
                float GB = Convert.ToInt32(Console.ReadLine());


                // Comparing Population //   
                if (A < B)
                {
                    greaterP = B;
                    smallerP = A;
                }
                else
                {
                    greaterP = A;
                    smallerP = B;
                }
                // Comparing Growth Rate //
                if (A < B)
                {
                    greaterR = GA;
                    smallerR = GB;
                }
                else
                {
                    greaterR = GB;
                    smallerR = GA;
                }
                // If the Growth rate if smaller population is less display the msg and repeat the process//
                if (greaterR < smallerR)
                {
                    Console.WriteLine("With this growth rate the smaller population will never be able to reach the population of the other country");
                }
            } while (greaterR < smallerR);


            int Years = YearsForecast(greaterP, smallerP, greaterR, smallerR);
            Console.WriteLine("");
            Console.WriteLine("Population A = " + smallerP);
            Console.WriteLine("Population B = " + greaterP);
            Console.WriteLine("Growth Rate of Population A = " + greaterR + "%");
            Console.WriteLine("Growth Rate of Population B = " + smallerR + "%");
            Console.WriteLine("Maintaining the growth rates, population A will be equal to or bigger than population B in " + Years + " years.");
        }
    }
}

