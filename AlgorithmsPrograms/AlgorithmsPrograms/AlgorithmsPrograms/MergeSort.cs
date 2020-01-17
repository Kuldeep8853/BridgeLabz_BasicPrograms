using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPrograms{
    class MergeSort{
        public static void Sort()
        {
            Console.WriteLine("Enter the array size.");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            Random random = new Random();
            for(int i = 0; i < N; i++)
            {
                array[i] = random.Next(20)-0;
            }
            PrintArray(array); 
            Merge_Sort(array,0,N-1);
            PrintArray(array);

        }
        private static void Merge_Sort(int[] array, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                Merge_Sort(array, l, m);
                Merge_Sort(array, m + 1, r);
                Merge(array, l, m, r);
            }
        }
        static void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            /* Create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];

            /*Copy data to temp arrays*/
            for (int i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (int j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            int a = 0, b = 0; 
            int k = l;
            while (a < n1 && b < n2)
            {
                if (L[a] <= R[b])
                {
                    arr[k] = L[a];
                    a++;
                }
                else
                {
                    arr[k] = R[b];
                    b++;
                }
                k++;
            }
            while (a < n1)
            {
                arr[k] = L[a];
                a++;
                k++;
            }
            while (b < n2)
            {
                arr[k] = R[b];
                b++;
                k++;
            }
        }
        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
