public class hanoi {
    public static void hanoi(int n, char from, char mid, char to) {
        if (n == 1) {
            printMove(n,from,to);
            return;
        }
        hanoi(n - 1, from, to, mid);
        printMove(n,from,to);
        hanoi(n - 1, mid, from, to);
    }

    public static void printMove(int n, char from, char to) {
        System.out.println("Диск " + n + " с палки : " + from + " на : " + to);
    }

    public static void main(String args[]) {
        int n = 3;
        hanoi(n, 'A', 'B', 'C');
    }

}