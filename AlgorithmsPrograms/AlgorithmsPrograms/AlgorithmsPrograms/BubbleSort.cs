using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPrograms{
    class BubbleSort{
        public static void Sort(){
            Console.WriteLine("Enter the array size.");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            Random random = new Random();
            for(int i = 0; i < N; i++)
            {
                array[i] = random.Next(10);
            }
            PrintArray(array);

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

            }
            Console.WriteLine("Sorted array.");
            PrintArray(array);

        }
        static void PrintArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

    }
}
