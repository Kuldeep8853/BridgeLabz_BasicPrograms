package com.myPrograms;
import java.util.Random;

public class TicTocTeoGame{
	public static void main(String[] args) { // Main Method start!!
		 String[][] board=new String[3][3];
		 String currentplayer="x";
		initilization(board);
		printBoard(board);
		while(!isFull(board)) {
		if(fillBoard(board,currentplayer)) {
			if(currentplayer=="x")
				currentplayer="0";
			else
				currentplayer="x";
		}
		printBoard(board);
		}
		if(isFull(board)) {
			checkWinner(board);
		}
	}                                          // Main Method end!!

	private static void initilization(String[][] board) {
	for(int i=0;i<3;i++) {
		for(int j=0;j<3;j++) {
			board[i][j]="_";
		}	
	 }
  }
	
	private static void printBoard(String[][] board) {
		System.out.println("--------------");
		for(int i=0;i<3;i++) {
			for(int j=0;j<3;j++) {
				System.out.print("| "+board[i][j]+" ");
			}
			System.out.println(" |");
			System.out.println("--------------");
		}
	}
	
	private static boolean isFull(String[][] board) {
		
		for (int i = 0; i < board.length; i++) {
			for (int j = 0; j < board.length; j++) {
				if(board[i][j]=="_")
					return false;
			}
		}
		return true;
	}
	private static boolean fillBoard(String[][] board,String currentplayer) {
		for(int i=0;i<3;i++) {
			for(int j=0;j<3;j++) {
				Random random=new Random();
				int row=random.nextInt(3);
				int column=random.nextInt(3);
				if(board[i][j]=="_") {
					board[row][column]=currentplayer;
					return true;
				}
			}
		}
		return false;
	}

	private static void checkWinner(String[][] board) {
		if(checkRow(board)=="x"||checkColumn(board)=="x"||checkDiagonal(board)=="x") {
			System.out.println(" Mr.X is Won the game!");
		}
		else if(checkRow(board)=="0"||checkColumn(board)=="0"||checkDiagonal(board)=="0")
			System.out.println("Mr.0 is Won the game!");
		else if(checkRow(board)==null||checkColumn(board)==null||checkDiagonal(board)==null)
			System.out.println("Drow the game!");
	  
	}

	private static String checkDiagonal(String[][] board) {
			if(board[0][0]=="x"&&board[1][1]=="x"&&board[2][2]=="x")
				return "x";
			else if(board[0][0]=="0"&&board[1][1]=="0"&&board[2][2]=="0")
				return "0";
			else if(board[0][2]=="x"&&board[1][1]=="x"&&board[2][0]=="x")
				return "x";
			else if(board[0][0]=="0"&&board[1][1]=="0"&&board[2][2]=="0")
				return "0";
			
			return null;
	}

	private static String checkColumn(String[][] board) {
		for(int i=0;i<3;i++){
			if(board[i][0]=="x"&&board[i][1]=="x"&&board[i][2]=="x")
				return "x";
			else if(board[i][0]=="0"&&board[i][1]=="0"&&board[i][2]=="0")
				return "0";
		}
		return null;
	}

	private static String checkRow(String[][] board) {
		for(int i=0;i<3;i++) {
			if(board[0][i]=="x"&&board[1][i]=="x"&&board[2][i]=="x")
				return "x";
			else if(board[0][i]=="0"&&board[1][i]=="0"&&board[2][i]=="0")
				return "0";
		}
		return null;
	}
	
}
