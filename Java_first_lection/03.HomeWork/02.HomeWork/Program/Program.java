// +Написать программу вычисления n-ого треугольного числа.

public class Program {
    public static void main(String[] args) {
        int n = 25;

        int[][] arr = new int[n][n*(n+1)/2];
        arr[0][0] = 1;
        for (int i = 1 ; i < n ; i ++){
            for (int j = 0 ; j <= i ; j ++){
                arr[i][j] = 1;
            }
        }
        PrintTrig(arr);

    }
    static void PrintTrig(int[][] arr){
        for (int[] row : arr) {
            System.out.println();
            for (int col : row){
                if (col != 0) System.out.printf(" %d " , col);
            }
        }
    }

}