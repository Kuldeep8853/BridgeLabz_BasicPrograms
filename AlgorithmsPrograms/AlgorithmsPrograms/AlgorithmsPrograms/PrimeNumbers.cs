using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPrograms{
    class PrimeNumbers{
        public static void FindAnagramPalindrome() {
            int count = 0;
            for (int i = 0; i <= 1000; i++){
                int factors = 0;
                for(int j = 1; j <= i / 2;j++){
                    if (i % j == 0)
                    {
                        factors++;
                    }
                    if (factors > 1)
                          break;                
                } 
                if (factors == 1)
                {
                    Console.Write(i+" ");
                    CheckPalindrom(i);
                    count++;
                }
            }
            Console.WriteLine("Count = " + count);
        }

        private static void CheckPalindrom(int i)
        {
            int n = i;
            int t = 0;
            while (n > 0)
            {
                int r = n % 10;
                t = t * 10 + r;
                n /= 10;
            }
            if (i == t)
                Console.WriteLine( " Number is Palindrom.");
        }

        private static Boolean CheckAnagram(int i)
        {
            Boolean b = false;
            int[] number = new int[10];
            int n = i;
            while (n > 0){
                int r = n % 10;
                number[r]++;
                n /= 10;

            }
            return b;
        }
    }
}
