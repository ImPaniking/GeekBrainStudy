public class Program {
    public static void main(String[] args) {
        int a = 5;
        int b = 5;
        int c = 2;
        int d = 1;
        int res = a;
        if ( a > b) System.out.printf("a : %d bigger then b : %d , no point in starting",a,b);
        else if (a == b) System.out.printf("a : %d equal's b : %d , no point in starting",a,b);

    }
    static boolean TestK1(int a,int b,int c,int d){
        while ( a*c <= b) a*=c;
        return a == b;
    }
    static boolean TestK2(int a,int b,int c,int d){
        while ( a+d <= b) a+=d;
        return a == b;
    }
}
