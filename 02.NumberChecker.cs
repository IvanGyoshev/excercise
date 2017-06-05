using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            double number= double.Parse(Console.ReadLine());
            bool result = (number % 1 == 0); //check for floating point number
            if (result) Console.WriteLine("integer");
            else Console.WriteLine("floating-point");
        }
    }
}
