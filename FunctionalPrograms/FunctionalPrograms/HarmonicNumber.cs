using System;

namespace FunctionalPrograms
{
    class HarmonicNumber{
        public static void FindNthHormonicNumber(){
            Console.WriteLine("Enter the number and find the nth hormonic value: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            float harmonic = 1;
            while (number > 0){
                harmonic += (float)1 / i;
                i++;
                number--;
            }
            Console.WriteLine(harmonic);
        }

    }
}
