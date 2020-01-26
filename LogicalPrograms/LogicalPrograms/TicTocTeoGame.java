import java.util.Scanner;

public class TicTocTeoGame {
	public static void main(String[] args) {
		Scanner scanner=new Scanner(System.in);
		System.out.print("Enter the 2D-Aarray size: ");
		int n=scanner.nextInt();
		String[][] TicTocGame=new String[n][n];
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < n; j++) {
				TicTocGame[i][j]=scanner.next();
			}
		}
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < n; j++) {
				System.out.print(TicTocGame[i][j]+" ");
			}
			System.out.println();
		}
		scanner.close();
	} 

}
