using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            double test1 = 80.0;
            double test2 = 90.0;
            double test3 = 95.0;
            double test4 = 75.0;
            double test5 = 80.0;

            double average = (test1 + test2 + test3 + test4 + test5) / 5.00;

            Console.WriteLine("Average: {0}.00", average);
        }
    }
}
