public class Program {
    public static void main(String[] args) {
        int a = 5;
        int b = 35;
        int c = 2;
        int d = 5;
        if ( a > b) System.out.printf("a : %d bigger then b : %d , no point in starting",a,b);
        else if (a == b) System.out.printf("a : %d equal's b : %d , no point in starting",a,b);
        else System.out.printf(workwork(a, b, c, d));
    }
    static boolean TestK1(int a,int b,int c,int d){
        while ( a*c < b) a*=c;
        return a == b;
    }
    static boolean TestK2(int a,int b,int c,int d){
        while ( a+d < b) a+=d;
        return a == b;
    }
    static String workwork(int a,int b,int c,int d){
        String result = "";
        do{
            if (TestK1(a,b,c,d)){
                result += "K1";
                a *= c;
            } else if (TestK2(a,b,c,d)){
                result += "K2";
                a += d;
            } else {
                if (a*c <= b) {
                    result += "K1";
                    a *= c;
                } else if (a+d <= b){
                    result += "K2";
                    a += d;
                } else result += "Eror";
            }
        } while(a<b);
        if (result.substring(result.length()-4,result.length()-1) == "Eror") result = "Eror";
        return result;
    }
}
