
using System;

namespace LogicalPrograms{
    class SnakeAndLadderGame{

        private static int playerOne=1;
        private static int playerTwo=1;
        public static void GameBoard()
        {
            int[,] gameBoard = new int[10, 10];
            InitializeBoard(gameBoard);
            PrintBoard(gameBoard);
            PlayGame();

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
        private static void PlayGame()
        {
            Random random = new Random();
            bool PlayerChange = true;
            while (playerOne<100 || playerTwo<100)
            {
                if (PlayerChange)
                {
                    int play1 = random.Next(6) + 1;
                    Console.WriteLine("First player throw the dies: " + play1);
                    playerOne += play1;
                    if (playerOne > 100)
                    {
                        playerOne -= play1;
                        Console.WriteLine("First Player score: " + playerOne);
                        
                    }
                    else
                    {
                        Console.WriteLine("First Player score: " + playerOne);
                    }
                    if (play1 == 6)
                    {
                        Console.Write("First player again throw  the dies: ");
                        int play3 = random.Next(6) + 1;
                        Console.WriteLine( play3);
                        playerOne += play3;
                        Console.WriteLine("First Player score: " + playerOne);
                    }
                    if (playerOne == 100)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("      !!Congrats!! ", Console.ForegroundColor);
                        Console.Write("First player win the game:", Console.ForegroundColor);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("", Console.ForegroundColor);
                        break;
                    }
                    if (Ladder(playerOne) > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" ## Add ladder in First player: " + Ladder(playerOne), Console.ForegroundColor);
                        playerOne += Ladder(playerOne);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("", Console.ForegroundColor);
                        Console.WriteLine("First Player score: " + playerOne);
                    }
                    if (Snake(playerOne) > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" $$ Subtract snake in First player: " + Snake(playerOne), Console.ForegroundColor);
                        playerOne -= Snake(playerOne);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("", Console.ForegroundColor);
                        Console.WriteLine("First Player score: " + playerOne);
                    }
                    PlayerChange = false;
                }
               if(!PlayerChange)
                {
                    int play2 = random.Next(6) + 1;
                    Console.WriteLine("Second player throw the dies: " + play2);
                    playerTwo += play2;
                    if (playerTwo > 100)
                    {
                        playerTwo -= play2;
                        Console.WriteLine("First Player score: " + playerTwo);
                       
                    }
                    else
                    {
                        Console.WriteLine("Second Player score: " + playerTwo);
                    }
                    if (play2 == 6)
                    {
                        Console.Write("Second player again throw  the dies: ");
                        int play3 = random.Next(6) + 1;
                        Console.WriteLine(play3);
                        playerOne += play3;
                        Console.WriteLine("Second Player score: " + playerTwo);
                    }
                    if (playerTwo == 100)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("     !!Congrats!! ", Console.ForegroundColor);
                        Console.Write("Second player win the game:", Console.ForegroundColor);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("", Console.ForegroundColor);
                        break;
                    }
                    if (Ladder(playerTwo) > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" ## Add ladder in second player: " + Ladder(playerTwo), Console.ForegroundColor);
                        playerTwo += Ladder(playerTwo);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("", Console.ForegroundColor);
                        Console.WriteLine("Second Player score: " + playerTwo);
                    }
                    if (Snake(playerTwo) > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" $$ Subtract snake in second player: " + Snake(playerTwo), Console.ForegroundColor);
                        playerTwo -= Snake(playerTwo);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("", Console.ForegroundColor);
                        Console.WriteLine("Second Player score: " + playerTwo);
                    }

                    PlayerChange = true;
                }
                
            }

        }
        private static int Ladder(int player)
        {
            if (player == 3)
            {
                return 58;
            }
            else if(player == 6)
            {
                return 21;
            }
            else if (player == 20)
            {
                return 50;
            }
            else if (player == 36)
            {
                return 19;
            }
            else if (player == 63)
            {
                return 32;
            }
            return 0;
        }
        private static int Snake(int player)
        {
            if (player == 34)
            {
                return 33;
            }
            else if(player == 25)
            {
                return 20;
            }
            else if (player == 47)
            {;
                return 25;
            }
            else if (player == 87)
            {
                return 30;
            }
            else if (player == 99)
            {
                return 33;
            }
            else if (player == 91)
            {
                return 23;
            }
          return 0;
        }
    }
}
