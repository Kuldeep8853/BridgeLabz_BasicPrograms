using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPrograms{
    class PrimeNumbers{
        public static void FindAnagramPalindrome() {
            for (int i = 1; i <= 1000; i++)
            {
                int factors = 0;
                int j = 1;

                while (j <= i)
                {
                    if (i % j == 0)
                    {
                        factors++;
                    }
                    j++;
                }
                if (factors == 2)
                {
                    CheckAnagramPalindrom(i);
                }
            }
        }

        private static void CheckAnagramPalindrom(int i)
        {
            Boolean b1=FindAnagram(i);
            if (b1)
                Console.Write("Anagram ");
            Boolean b2 = FindPalindrome(i);
            if(b2)
                Console.Write("Palindrom ");



        }

        private static Boolean FindAnagram(int i)
        {
            Boolean b = false;
            int[] number = new int[10];
            int n = i;
            while (n > 0){
                int r = n % 10;
                number[r]++;
                n = n / 10;

            }
            return b;
        }
        private static Boolean FindPalindrome(int i)
        {
            Boolean b = false;

            return b;
        }
    }
}
