using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms{
    class WindChill{
        public static void FindWindChill()
        {
            double t = Convert.ToDouble(Console.ReadLine());
            double v = Convert.ToDouble(Console.ReadLine());
            double w = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
            Console.WriteLine("Temperature = " + t);
            Console.WriteLine("Wind speed  = " + v);
            Console.WriteLine("Wind chill  = " + w);
        }
    }
}
