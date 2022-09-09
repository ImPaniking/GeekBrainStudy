/*
 * множество - совокупность неповторяющихся эллементов
 *  упорядоченные множества
 * набор - набор эллементов которые могут повторяться
 * последовательность - совокупность эллементов , где важен их порядок
 *  подпоследовательность - получается из последовтельности из которой убрали какие-то эллементы ( через 1 / через 2 и так далее )? 
 * 
 * даны 2 последовательности , найти длину наибольшей подпоследовательности
 */
import java.util.ArrayList;
import java.util.Random;
import java.util.Arrays;
import java.util.List;


public class Program {
    public static void main(String[] args) {
        Random rnd = new Random();
        ArrayList<Integer> listA = new ArrayList<Integer>();
        for (int i = 0 ; i < 10 ; i ++) listA.add(rnd.nextInt(10));
        ArrayList<Integer> listB = new ArrayList<Integer>();
        for (int i = 0 ; i < 10 ; i ++) listB.add(rnd.nextInt(10));

        ArrayList<Integer> res = new ArrayList<Integer>();
        ArrayList<ArrayList<Integer>> podListA = new ArrayList<ArrayList<Integer>>();
        ArrayList<Integer> podListB = new ArrayList<Integer>();

        System.out.println("Array A :");
        System.out.println(listA);
        System.out.println("Array B :");
        System.out.println(listB);

        podListA = PodPod(listA);
        for (ArrayList<Integer> ArrInt : podListA) {
            System.out.println(ArrInt);
            for (Integer numbers : ArrInt){
                System.out.println(numbers);
            }
        }

    }
    static ArrayList<ArrayList<Integer>> PodPod(ArrayList<Integer> a){
        ArrayList<Integer> res = new ArrayList<Integer>();
        ArrayList<ArrayList<Integer>> resReturn = new ArrayList<ArrayList<Integer>>();
        for (int n = 1 ; n < a.size() ; n++){
            for (int i = 0 ; i < a.size(); i++){
                System.out.println(resReturn);
                res.clear();
                for (int j = i; j <a.size() ; j+=n){
                    res.add(a.get(j));
                }
                System.out.println(res);
                if (!IsInList(res,resReturn)){
                    resReturn.add(res);
                }
            }
        }
        return resReturn;
    }
    static boolean IsInList(ArrayList<Integer> a,ArrayList<ArrayList<Integer>> b){
        boolean AinB = false;
        for (ArrayList<Integer> arrayList : b) {
            if (a == arrayList){
                AinB = true;
                break;
            }
        }
        return AinB;
    }
}


/*
 *  1 , 2 , 3 , 4 , 5
 *  
 * 2*n -1
 */