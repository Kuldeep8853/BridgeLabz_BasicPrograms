using System;

namespace LogicalPrograms
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the your choice: ");
            Console.WriteLine("1. Gambler game. ");
            Console.WriteLine("2. Coupon Numbers Program. ");
            Console.WriteLine("3. Simulate Stopwatch Program. ");
            Console.WriteLine("4. Tic tac Toe game. ");
            int choice= Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:{
                        Gambler.FindWinLos();
                        break;
                    }
                case 2:{
                        CouponNumbers.GenerateCouponNumbers();
                        break;
                    }
                case 3:
                    {
                        StopwatchProgram.GetElapsedTime();
                        break;
                    }
                case 4:
                    {
                        TicTacToeGame.FindWhoWin();
                        break;
                    }
                default: 
                    {
                        Console.WriteLine("Please select valid choice.");
                        break;
                    }
            }
        }
    }
}
