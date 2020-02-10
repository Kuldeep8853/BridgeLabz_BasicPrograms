
using System;

namespace LogicalPrograms{
    class SnakeAndLadderGame{

        public static void GameBoard()
        {
            int[,] gameBoard = new int[10, 10];
            InitializeBoard(gameBoard);
            PrintBoard(gameBoard);

        }

        private static void InitializeBoard(int[,] gameBoard)
        {
            int k = 100;
            for(int i = 0; i <10; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j <10; j++)
                    {
                        gameBoard[i, j] = k--;
                    }
                }
                else
                {
                    for(int j = 9; j >= 0; j--)
                    {
                        gameBoard[i, j] = k--;
                    }
                }
            }

        }
        private static void PrintBoard(int[,] gameBoard)
        {
            Console.WriteLine("--------------------------------------------------------------");
            for (int i = 0; i < 10; i++)
            {
               
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("| "+ gameBoard[i, j].ToString("000") + " ");
                   
                }
                Console.WriteLine(" |");
                Console.WriteLine("--------------------------------------------------------------");
            }
        }
    }
}
