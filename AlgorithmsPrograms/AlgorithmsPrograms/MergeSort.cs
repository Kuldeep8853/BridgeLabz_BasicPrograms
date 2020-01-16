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
            Console.WriteLine();
            Merge_Sort(array);
           
        }
        private static void Merge_Sort(int[] A)
        {
            if (A.Length > 1)
            {
                int q = A.Length / 2;
                int[] leftArray = CopyOfRange(A, 0, q);
                int[] rightArray = CopyOfRange(A, q + 1, A.Length-1);
                Merge_Sort(leftArray);
                Merge_Sort(rightArray);
                A = Merge(leftArray, rightArray);
            }
            PrintArray(A);
        }
        static int[] Merge(int[] l, int[] r)
        {
            int totElem = l.Length + r.Length;
            int[] a = new int[totElem];
            int i, li, ri;
            i = li = ri = 0;
            while (i < totElem)
            {
                if ((li < l.Length) && (ri < r.Length))
                {
                    if (l[li] < r[ri])
                    {
                        a[i] = l[li];
                        i++;
                        li++;
                    }
                    else
                    {
                        a[i] = r[ri];
                        i++;
                        ri++;
                    }
                }
                else
                {
                    if (li >= l.Length)
                    {
                        while (ri < r.Length)
                        {
                            a[i] = r[ri];
                            i++;
                            ri++;
                        }
                    }
                    if (ri >= r.Length)
                    {
                        while (li < l.Length)
                        {
                            a[i] = l[li];
                            li++;
                            i++;
                        }
                    }
                }
            }
            return a;
        }
        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        private static int[] CopyOfRange(int[] arr, int v, int q)
        {
          
            int j = 0;
            for (int i = v; i <=q; i++)
            {
                arr[j] = arr[i];
                j++;
            }
            return arr;
        }
    }
}
