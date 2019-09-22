using InterfaceSegregationPrinciple.DVDs;
using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IBorrowableDVD dvd = new DVD();

            Console.ReadLine();
        }
    }
}
