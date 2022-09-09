import java.lang.reflect.Array;
import java.util.Random;

public class NewProgram {
    public static void main(String[] args) {
        int n = 10;
        // int arrayLength = Math.pow(2, n)
        int[] arrayA = RandomArray(n,1,11);
        System.out.println("Array A:");
        System.out.println(arrayA);
        int[] arrayB = RandomArray(n,1,11);
        System.out.println("Array B:");
        System.out.println(arrayB);
        

        
    }
    static int[] RandomArray(int length,int min,int max){
        Random rnd = new Random();
        int[] array = new int[length];
        for (int i = 0 ; i < length ; i ++) array[i] = rnd.nextInt(min,max);
        return array;
    }

    static int[][] PodPod(int[] a){
        int[][] array = new int[10000][10000];
        
        return array;
    }
}

