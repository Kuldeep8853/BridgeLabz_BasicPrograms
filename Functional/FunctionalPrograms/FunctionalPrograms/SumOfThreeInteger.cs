using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class SumOfThreeInteger{
        public static void FindTriplats(){
            Console.WriteLine("Enter the size of array");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            Console.WriteLine("Enter the array elements: ");
            for (int i = 0; i< N; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < N - 2; i++)
            {
                for(int j = i + 1; j < N - 1; j++)
                {
                    for(int k = j + 1; k < N; k++)
                    {
                        if (array[i] + array[j] + array[k] == 0)
                            Console.WriteLine(array[i] + " " + array[j] + " " + array[k]);
                    }
                }
            }

        }

    }
}
