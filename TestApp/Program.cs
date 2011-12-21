using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //a. Have the program go through the numbers 1 to 100 (inclusive)
            //I am excluding 0 here, per the directions
            for (int i = 1; i <= 100; i++)
            {
                //If the number is divisible by both 3 and 5, output ModernMedical
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("ModernMedical");
                }
                //If the number is divisible by 3 only, output Modern
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Modern");
                }
                //If the number is divisible by 5 only, output Medical
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Medical");
                }
                //If the number is not divisible by either 3 or 5, only output the number itself.
                else
                {
                    Console.WriteLine(i.ToString());
                }
            }
            //Pause for the evaluation of output
            Console.ReadLine();
        }
    }
}
