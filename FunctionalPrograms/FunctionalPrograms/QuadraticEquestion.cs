using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms{
    class QuadraticEquestion{
        public static void FindRoot(){
            Console.WriteLine("Enter three coefficients");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("The roots1 are: " + Math.Abs(root1));
            Console.WriteLine("The roots2 are: " + Math.Abs(root2));
        }
    }
}
