using System;

namespace FunctionalPrograms{
    public class LeapYearProgram{
        public static void FindLeapYear(){
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                Console.WriteLine("It is leap year ");
            else
                Console.WriteLine("It is not a leap year");
        }
    }
}
