using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int year = int.Parse(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("Leap Year");
            else Console.WriteLine("Not a Leap Year");
        }
    }
}
