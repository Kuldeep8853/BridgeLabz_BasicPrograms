using System;

namespace FunctionalPrograms{
    class DistanceP{
        public static void FindDistance()
        {
            Console.WriteLine("Enter the x and y co-ordinates: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            // Calculating distance 
            double distance= Math.Sqrt(Math.Pow(x1, 2) +Math.Pow(y1, 2) * 1.0);
            Console.WriteLine(Math.Round(distance * 100000.0) / 100000.0);
        }

    }
}
