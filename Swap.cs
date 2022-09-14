using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers");
            int a = int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine($"Initial values : a = {a} , b = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Final values : a = {a} , b = {b}");
        }
    }
}
