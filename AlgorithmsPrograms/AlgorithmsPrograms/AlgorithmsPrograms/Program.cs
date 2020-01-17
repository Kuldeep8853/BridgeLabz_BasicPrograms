using System;

namespace AlgorithmsPrograms
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enetr the choice.");
            Console.WriteLine("1. Find Permutation.");
            Console.WriteLine("2. Bubble sort.");
            Console.WriteLine("3. Merge sort.");
            Console.WriteLine("4. Find Anagram or not.");
            Console.WriteLine("5. find the prime numbers that are Anagram and Palindrome.");
            Console.WriteLine("6. Binary Search.");
            Console.WriteLine("7. Regular Expresion.");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Permutation.FindPermutation();
                        break;
                    }
                case 2:
                    {
                        BubbleSort.Sort();
                        break;
                    }
                case 3:
                    {
                        MergeSort.Sort();
                        break;
                    }
                case 4:
                    {
                        Anagram.FindAnagram() ;
                        break;
                    }
                case 5:
                    {
                        PrimeNumbers.FindAnagramPalindrome();
                        break;
                    }
                case 6:
                    {
                        BinarySearch.Search();
                        break;
                    }
                case 7:
                    {
                        CustomizeRegEx.RegExFuction();
                        break;
                    }
                default:
                    Console.WriteLine("Choice not valid.");
                    break;
            }
        }
    }
}
