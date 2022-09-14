using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Shopkeeper
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter product number and quantity");
            int pNo=int.Parse(Console.ReadLine());
            int q=int.Parse(Console.ReadLine());
            double price = 0;
            switch (pNo) {
                case 1:
                    price = 22.50;
                    break;
                case 2:
                    price = 44.50;
                    break;
                case 3:
                    price = 9.98;
                    break;
                default:
                    Console.WriteLine("Wrong Product Number");
                    break;

            }
            Console.WriteLine("Total Retail Value = "+q*price);
        }
    }
}
