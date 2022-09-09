/*
 * Многострочный комментарий
 */

 // И такой вариант комментариев

 /*
  * 1. Главное касс
    2. В нём метод
    3. В нём код
  */
import java.util.Scanner;
import java.io.FileWriter;
import java.io.FileReader;
import java.io.IOException;
public class program {
    public static void main(String[] args) {
        System.out.println("Hello world");

        String s = "2";
        String x = null;

        System.out.println(s);
        System.out.println(x);

        float f = 2.547f;
        double k = 2.547;

        System.out.println(f);
        System.out.println(k);
        k = 2.547D;
        System.out.println(k);

        char ch = '{';
        System.out.println(ch);
        ch = 123;
        System.out.println(ch);

        boolean boo = f > k;
        System.out.println(boo);

        String msg = "Hello world";
        System.out.println(msg);

        var i = 123;
        System.out.println(getType(i));

        int y = 2_147_483_647;
        System.out.println(Integer.MAX_VALUE);
        System.out.println(y);
        char test;
        test = msg.charAt(1);
        System.out.println(test);

        int a = 123;
        a = a-- - --a;// вывод 2 - как ? 
        System.out.println(a);

        int j = 5;
        int h = 2;
        System.out.println(j | h);

        int[] arr = new int[10];
        System.out.println(arr);
        arr = new int[] {1,2,3,4,5};
        System.out.println(arr);
        System.out.println(arr.length);

        int[] arra[] = new int[3][5];
        for (int[] line : arra){
          for (int item : line){
            System.out.printf("%d " , item);
          }
        }

        int[][] ar = new int[3][5];
        for (int p = 0 ; p < ar.length ; p++){
          System.out.println();
          for (int l = 0 ; l < ar[p].length ; l++){
            System.out.printf("%d ",ar[p][l]);
          }
        }
        System.out.println(); 
        byte b = Byte.parseByte("12");
        System.out.println(b);


        Scanner iScanner = new Scanner(System.in);
        System.out.printf("input name :");
        String name = iScanner.nextLine();
        System.out.printf("Hello ,%s!", name);


        System.out.printf("input int q :");
        int q = iScanner.nextInt();
        System.out.printf("input double w :");
        double w = iScanner.nextDouble();
        System.out.printf("%d + %f = %f", q,w,q+w);

        System.out.printf("input e :");
        boolean flag = iScanner.hasNextInt();
        System.out.println(flag);
        int e = 0;
        if (flag){
          e = iScanner.nextInt();
        }
        System.out.println(e);

        int r = 5, t = 6;
        int u = r+t;
        String res = String.format("%d + %d = %d\n",r,t,u);
        System.out.printf("%d + %d = %d\n",r,t,u);
        System.out.println(res);
        /*
         * %d - целочисленное значение
         * %x - для вывода шеснадцетеричных чисел
         * %f - для вывода чисел с лпвающей запятой
         * %.3f - 3 знака после запятой
         * %e - для вывода чисел в экспоненциальной форме
         * %c - для вывода одиночного символа
         * %s - для вывода строковых значений
         */

        iScanner.close();

        // Scanner hScanner = new Scanner(System.in);
        // System.out.printf("input int q :");
        // int q = hScanner.nextInt();
        // System.out.printf("input double w :");
        // double w = hScanner.nextDouble();
        // System.out.printf("%d + %f = %f", q,w,q+w);
        // hScanner.close();

        {
          int d = 555;
          System.out.println(d);
        }
        int d = 123;
        System.out.println(d);

        MethodLib.sayHi();

        int m = 1;
        int n = 2;
        int min = m < n ? a : b;
        System.out.println(min);

        switch (m){
          case 1:
          case 2:
          case 3:
          case 4:
            System.out.println('a');
            break;
        }

        int[] arrr = new int[] {1,2,3,4,5,6,7};
        for (var item: arrr) System.out.println(item);

        try (FileWriter fw = new FileWriter("file.txt" , false)){
          fw.write("Line 1");
          fw.append("\n");
          fw.append("2");
          fw.append("\n");
          fw.write("Line 3");
          fw.flush();

        } catch (IOException ex){
          System.out.println(ex.getMessage());
        }

        // FileReader fr = new FileReader("file.txt");
        //   int c;
        //   while ((c = fr.read()) != -1) {
        //     char ca = (char) c;
        //     if (ca == '\n') {
        //       System.out.println(ca);
        //     }else {
        //       System.out.println(ca);
        //     }
        //   }

    }
    static String getType(Object o){
        return o.getClass().getSimpleName();
    }
    
}
