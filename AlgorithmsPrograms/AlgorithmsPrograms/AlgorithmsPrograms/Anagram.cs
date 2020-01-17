using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPrograms{
    class Anagram{
        public static void FindAnagram()
        {
            Console.WriteLine("Enter the two string.");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            if (str1.Length != str2.Length)
                Console.WriteLine(" Entered string is not anagram.");
            else
            {
                int charLength = 128;

                int[] counter = new int[charLength];

                for (int i = 0; i < str1.Length; i++)
                {
                    counter[str1[i] - 'a']++;
                    counter[str2[i] - 'a']--;
                }

                for (int c = 0; c < charLength; c++)
                {
                    if (counter[c] != 0)
                        Console.WriteLine(" Entered string is not anagram.");
                }

                Console.WriteLine("  Anagram.");
            }
        }
    
    }
}
