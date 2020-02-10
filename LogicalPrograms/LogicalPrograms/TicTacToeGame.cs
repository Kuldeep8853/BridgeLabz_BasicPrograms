using System;

namespace LogicalPrograms{
    class TicTacToeGame{

		public static void FindWhoWin()
		{
			string[,] board = new string[3,3];
			string currentplayer = "x";
			PrintBoard(board);
			Initilization(board);
			PrintBoard(board);
			while (!IsFull(board))
			{
				if (FillBoard(board, currentplayer))
				{
					if (currentplayer == "x")
						currentplayer = "0";
					else
						currentplayer = "x";
				}
				PrintBoard(board);
			}
			if (IsFull(board))
			{
				CheckWinner(board);
			}
		}

		private static void Initilization(string[,] board)
		{
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					board[i,j] = "_";
				}
			}
		}

		private static void PrintBoard(string[,] board)
		{
			Console.WriteLine("--------------");
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write("| " + board[i,j] + " ");
				}
				Console.WriteLine(" |");
				Console.WriteLine("--------------");
			}
		}

		private static bool IsFull(string[,] board)
		{

			for (int i = 0; i < board.Length; i++)
			{
				for (int j = 0; j < board.Length; j++)
				{
					if (board[i, j] == "_")
					{
						return false;
					}
				}
			}
			return true;
		}
		private static bool FillBoard(string[,] board, string currentplayer)
		{
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Random random = new Random();
					int row = random.Next(3);
					int column = random.Next(3);
					if (board[i,j] == "_")
					{
						board[row,column] = currentplayer;
						return true;
					}
				}
			}
			return false;
		}

		private static void CheckWinner(string[,] board)
		{
			if ((CheckRow(board) == "x" || CheckColumn(board) == "x" || CheckDiagonal(board) == "x")&&!(CheckRow(board) == "0" || CheckColumn(board) == "0" || CheckDiagonal(board) == "0"))
			{
				Console.WriteLine(" Mr.X is Won the game!");
			}
			else if ((CheckRow(board) == "0" || CheckColumn(board) == "0" || CheckDiagonal(board) == "0")&& !(CheckRow(board) == "x" || CheckColumn(board) == "x" || CheckDiagonal(board) == "x"))
				Console.WriteLine("Mr.0 is Won the game!");
		else if (CheckRow(board) == null || CheckColumn(board) == null || CheckDiagonal(board) == null || (CheckRow(board) == "x" || CheckColumn(board) == "x" || CheckDiagonal(board) == "x") && (CheckRow(board) == "0" || CheckColumn(board) == "0" || CheckDiagonal(board) == "0"))
				Console.WriteLine("Drow the game!");

		}

		private static string CheckDiagonal(string[,] board)
		{
			if (board[0,0] == "x" && board[1,1] == "x" && board[2,2] == "x")
				return "x";
			else if (board[0,0] == "0" && board[1,1] == "0" && board[2,2] == "0")
				return "0";
			else if (board[0,2] == "x" && board[1,1] == "x" && board[2,0] == "x")
				return "x";
			else if (board[0,0] == "0" && board[1,1] == "0" && board[2,2] == "0")
				return "0";

			return null;
		}

		private static string CheckColumn(string[,] board)
		{
			for (int i = 0; i < 3; i++)
			{
				if (board[i,0] == "x" && board[i,1] == "x" && board[i,2] == "x")
					return "x";
				else if (board[i,0] == "0" && board[i,1] == "0" && board[i,2] == "0")
					return "0";
			}
			return null;
		}

		private static string CheckRow(string[,] board)
		{
			for (int i = 0; i < 3; i++)
			{
				if (board[0,i] == "x" && board[1,i] == "x" && board[2,i] == "x")
					return "x";
				else if (board[0,i] == "0" && board[1,i] == "0" && board[2,i] == "0")
					return "0";
			}
			return null;
		}


	}
}

