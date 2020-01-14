using System;
using System.Diagnostics;
using System.Threading;
namespace LogicalPrograms
{
    public class StopwatchProgram {
       
        public static void GetElapsedTime() 
        {
            Console.WriteLine("Enter the Starting time in'HH:MM:SS' formate:");
            string startingTime = Console.ReadLine() + ":" + Console.ReadLine() + ":" + Console.ReadLine();
            string[] str = startingTime.Split(":");
            int sHH = Convert.ToInt32(str[0]);
            int sMM = Convert.ToInt32(str[1]);
            int sSS = Convert.ToInt32(str[2]);

            Console.WriteLine("Enter the End time in'HH:MM:SS' formate:");
            string EndTime = Console.ReadLine() + ":" + Console.ReadLine() + ":" + Console.ReadLine();
            string[] str1 = EndTime.Split(":");
            int eHH = Convert.ToInt32(str1[0]);
            int eMM = Convert.ToInt32(str1[1]);
            int eSS = Convert.ToInt32(str1[2]);

            int elepsedTime = Stop(eHH,eMM,eSS)-Start(sHH, sMM, sSS);

            Console.WriteLine("HH:MM:SS = "+elepsedTime/(60*60)+":"+((elepsedTime/60)-(elepsedTime / (60 * 60)*60))+":"+elepsedTime%60);
        }
        static int Start(int HH,int MM,int SS) {
            int second = HH * 3600 + MM * 60 + SS;
            return second;
        }
        static int Stop(int HH, int MM, int SS){
            int second = HH * 3600 + MM * 60 + SS;
            return second;

        }
    }
}

