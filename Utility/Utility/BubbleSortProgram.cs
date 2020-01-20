using System;
using System.Collections.Generic;
using System.Text;

namespace Utility{
   public class UtilityProgram{
        public static void InsertionSort(int[] arr){  //Insertion sorting for Integer  type array. 
            int i, j, temp;
            for (i = 1; i < arr.Length; i++){
                for (j = i; j > 0 && arr[j - 1] > arr[j]; j--){
                    temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                }
            }
        }
       public  static  void BubbleSort(int[] arr){ //bubble Sorting Integre array. 
            for (int i = 0; i < arr.Length; i++){
                for (int j =1; j < arr.Length-i; j++){
                    if (arr[j-1] > arr[j]){
                        int temp = arr[j-1];
                        arr[j-1] = arr[j];
                        arr[j-1] = temp;
                    }
                }
            }
        }
        public static void BubbleSort(string[] arr){ //bubble Sorting string array.
            for (int i = 0; i < arr.Length; i++){
                for (int j = 1; j < arr.Length - i; j++){
                    if (arr[j - 1].CompareTo(arr[j])<0){
                        string temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j - 1] = temp;
                    }
                }
            }
        }
        public static void PrintArray(int[] arr){  //print integer type array.
        
            for (int i = 0; i < arr.Length; i++){
                Console.WriteLine(arr[i] + " ");
            }
        }
        public static void PrintArray(string[] arr){  //print string type array.
            for (int i = 0; i < arr.Length; i++){
                Console.WriteLine(arr[i] + " ");
            }
        }
        public static int UserInputInteger(){ //Integer type user input. 
            int N = Convert.ToInt32(Console.ReadLine());
            return N;
        }
        public static string UserInputString(){ //string type user input.
            string  str = Console.ReadLine();
            return str;
        }
    }
}
