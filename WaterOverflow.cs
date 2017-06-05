using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int liters = 0;
            int volume = 255;
            for (int i=1; i<=n; i++)
            {
                liters = int.Parse(Console.ReadLine());
                if (volume - liters < 0) Console.WriteLine("Insufficient capacity!");
                else volume -= liters;                
            }
            Console.WriteLine(255 - volume);
        }
    }
}
