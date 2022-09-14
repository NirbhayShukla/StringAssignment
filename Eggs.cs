using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Eggs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Eggs");
            int eggs=int.Parse(Console.ReadLine());
            int gross = 0, dozen = 0, left = 0;
            gross = eggs / 144;
            eggs -= 144 * gross;
            dozen = eggs / 12;
            eggs -= 12 * dozen;
            left = eggs;
            string ans = "Your number of eggs is ";
            if (gross > 0) ans += gross + " gross ";
            if (dozen > 0) ans += dozen + " dozen ";
            if (left > 0) ans += "and " + left;
            Console.WriteLine(ans);
        }
    }
}
