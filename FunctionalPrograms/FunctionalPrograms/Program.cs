using FunctionalPrograms;
using System;
namespace FunctionalPrograms{
    public class Program{
        public static void Main() {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the choice:- ");
            Console.WriteLine("1. Find head and tail percentage.");
            Console.WriteLine("2. Find leap year or not.");
            Console.WriteLine("3. Get power of two table.");
            Console.WriteLine("4. Find the Nth harmonic Value.");
            Console.WriteLine("5. Find the Prime factors.");
            Console.WriteLine("6. Print the 2D array.");
            Console.WriteLine("7. Find the triplats in the array elements.");
            Console.WriteLine("8. Find the distance between origin and given point.");
            Console.WriteLine("9. Find the Roots.");
            Console.WriteLine("10. Find the WindChill.");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number) {
                case 1:
                    {
                        FlipCoin.GetPercentage();
                        break;
                    }
                case 2:
                    {
                        LeapYearProgram.FindLeapYear();
                        break;
                    }
                case 3:
                    {
                        PowerOfTwo.FindPowerOfTwo();
                        break;
                    }
                case 4:
                    {
                        HarmonicNumber.FindNthHormonicNumber();
                        break;
                    }
                case 5:
                    {
                        Factors .FactorsOfNumber();
                        break;
                    }
                case 6:
                    {
                        TwoDArray.ArrayInt();
                        break;
                    }
                case 7:
                    {
                        SumOfThreeInteger.FindTriplats();
                        break;
                    }
                case 8:
                    {
                        DistanceP.FindDistance();
                        break;
                    }
                case 9:
                    {
                        QuadraticEquestion .FindRoot();
                        break;
                    }
                case 10:
                    {
                        WindChill.FindWindChill();
                        break;
                    }
                default:
                    Console.WriteLine("No match found");
                    break;

            }
        }

    }
}
