import java.util.Random;
import java.util.Arrays;

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
        int[][] array = new int[10000][a.length];
        int index = 0;
        int index_2 = 0;
        int[] tempArray = new int[a.length];
        for (int i =0 ; i < a.length ; i ++){
            Arrays.fill(tempArray,0);
            for ( int j = i ; j < a.length ; j ++){
                tempArray[index_2] = a[j];
                index_2++;
            if (InArray(array,tempArray)){
                array[index] = tempArray;
                index++;
            }

            }
        }
        
        return array;
    }
    static boolean InArray(int[][] a , int[] b){
        boolean boo = false;
        for (int[] tempArr : a){
            if (b == tempArr){
                boo = true;
                break;
            }
        }
        return boo;
    }    
}

