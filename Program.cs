using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double multiplier = 1.2;
            double multiplied;
            int numHolder;
            int reverse = 0;

            String[] numArray = System.IO.File.ReadAllLines(@"input.txt");

            for (int i = 0; i < numArray.Length; i++)
            {
                reverse = 0;

                numHolder = Int32.Parse(numArray[i]);
                multiplied = numHolder * multiplier;

                while (numHolder > 0)
                {
                    reverse = reverse * 10 + numHolder % 10;
                    numHolder = numHolder / 10;
                }

                if(multiplied == reverse)
                {
                    Console.WriteLine(numArray[i] + " when reversed to create " + reverse + " is increased by 1/5th of it's value");
                    Console.ReadKey();
                }
            }

            Console.ReadKey();
        }
    }
}
