import java.util.ArrayList;
public class mnojeteli {
    public static void main(String[] args){
        String test = "25x^3+5x^2+10x+5";
        char[] arr = new char [test.length()];
        for (int i=0 ; i < test.length();i++){
            arr[i] = test.charAt(i);
        }
        String result = "";
        ArrayList<String> newList = new ArrayList<String>();
        for (int i=0 ; i < arr.length;i++){
            System.out.println(arr[i]);
            if (isInt(Character.toString(arr[i]))){
                result += Character.toString(arr[i]);
            } else {
                if (result != ""){
                    newList.add(result);
                    result = "";
                    newList.add(Character.toString(arr[i]));
                } else {
                    newList.add(Character.toString(arr[i]));
                }
            }    
        }
        if (result != ""){
            newList.add(result);
        }
        System.out.println(newList);
    }
    public static boolean isInt(String a){
        try { 
            Integer.parseInt(a); 
            return true; 
            } catch (NumberFormatException e) {
            return false; 
            } 
      }
}
