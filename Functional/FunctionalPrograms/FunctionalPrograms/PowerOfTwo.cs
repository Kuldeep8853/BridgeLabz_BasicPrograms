using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class PowerOfTwo{
        public static void FindPowerOfTwo(){
            Console.WriteLine("Enter the Number And find the powers of 2");
            int number= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table of the powers of 2 ");
            int i = 0;
            int power = 1;
            while (number >=0){
                Console.WriteLine("2^" + i + " = " +power );
                power *= 2;
                number--;
                i++;
            }
        }
    }
}
