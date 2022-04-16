using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Inclass_5
    {
        static char c, d;
        static void Main(string[] args)
        {

            ///Part 1
            Console.WriteLine("Enter First & Last Name separated by Space:");
            String Name = Console.ReadLine();
            int split_index = Name.IndexOf(" ");
            Console.WriteLine(split_index);
            for (int i = split_index + 1; i < Name.Length; i++)
            {
                Console.Write(Name[i]);
            }
            Console.Write(" ");
            for (int i = 0; i < split_index; i++)
            {
                Console.Write(Name[i]);
            }
            Console.WriteLine();

            /// Part 2
            Console.WriteLine("Enter the 12 digit Barcode without space to validate:  ");
            String InBarcode = Console.ReadLine();
            int OddSum = 0, EvenSum = 0;
            
            if (InBarcode.Length == 12)
            {
                for (int i = 0; i <= InBarcode.Length;)
                {
                    // Console.WriteLine(InBarcode[i]);
                    c = InBarcode[i];
                    d = InBarcode[i + 1];
                    OddSum += (int)(c - '0');
                    EvenSum += (int)(d - '0');
                    Console.WriteLine(InBarcode[i]);
                    Console.WriteLine("Sum is {0}", EvenSum);
                    //char C = InBarcode[i];
                    //Console.WriteLine((int)(C - '0'));
                    i += 2;

                    // Console.WriteLine("OddSum& EvenSum is {0}, {0}", OddSum, EvenSum);
                    if (i >= InBarcode.Length)
                    {
                        Console.WriteLine("Index is {0}", i);
                        break;
                    }

                }
                char f = InBarcode[11];
                EvenSum = EvenSum - ((int)(f - '0'));
            }
            Console.WriteLine("Oddsum is {0}", OddSum);
            Console.WriteLine("EvenSum is {0}", EvenSum);
            int Resultant = (OddSum * 3) + EvenSum;
            Console.WriteLine(Resultant);
            Console.WriteLine(Resultant % 10);
            if ((Resultant / 10) != 0)
            {
                char Calc_Check_Digit = (char)(10 - (Resultant % 10));
                if (Calc_Check_Digit == d)
                {
                    Console.WriteLine("BARCODE VALID");
                }
                else
                {
                    Console.WriteLine("INVALID BARCODE");
                }
            }


            Console.ReadLine();
    }
}