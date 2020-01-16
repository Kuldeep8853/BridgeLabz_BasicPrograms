using System;

namespace AlgorithmsPrograms
{
    class Permutation{
      public static void FindPermutation(){
            Console.WriteLine("Enetr the String and find Permutation.");
            string str = Console.ReadLine();
            char[] charArry = str.ToCharArray();
            Console.WriteLine("Permutation of given string.");
            permute(charArry, 0, 2);
        }

        static void permute(char[] arry, int i, int n)
        {
            int j;
            if (i == n)
                Console.WriteLine(arry);
            else
            {
                for (j = i; j <= n; j++)
                {
                    swap(ref arry[i], ref arry[j]);
                    permute(arry, i + 1, n);
                    swap(ref arry[i], ref arry[j]); //backtrack
                }
            }
        }

       private static void swap(ref char a, ref char b)
        {
            char tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
    }
}

