using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPrograms{
    class BinarySearch{
        public static void Search(){
            Random random = new Random();
            Console.WriteLine("Enter the array size.");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            for(int i = 0; i < N; i++)
            {
                array[i] = random.Next(100) - 0; 
            }
            Sort(array);
            PrintArray(array);
            Console.WriteLine("Enter the Key and find its index.");
            int key = Convert.ToInt32(Console.ReadLine());
            int l = 0;
            int h = N - 1;
           int index= Binary_Search(array,l,h, key);
            if (index == -1)
                Console.WriteLine("Index not found.");
            else
                Console.WriteLine("Index of key = "+index );

        }

        private static int Binary_Search(int[] array,int l,int h, int key)
        {
            int mid = 0;
            if (l <= h)
               mid = l + (h - l) / 2;

            if (key == array[mid])
                return mid;
          
            else if (l == h)
                return -1;

            else if (array[mid] > key)
                return Binary_Search(array, l, mid - 1, key);

            else
                return Binary_Search(array, mid + 1, h, key);
        }

        private static void Sort(int[] array)
        {
            int n = array.Length;
            for(int i = 0; i < n; i++)
            {
                for(int j = 1; j < n - i; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        int tamp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = tamp;
                    }
                }  
            }
        }
        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
