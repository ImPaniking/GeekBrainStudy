/**
 * pro
 */
public class Program {

    static int Lmp(String a, String b) {
      if (a.length() == 0 || b.length() == 0) {
        return 0;
      } else if (a.charAt(0) == b.charAt(0)) {
        return 1 + Lmp(a.substring(1, a.length()), b.substring(1, b.length()));
      } else {
        return Math.max(Lmp(a.substring(1, a.length()), b),
            Lmp(a, b.substring(1, b.length())));
      }
    }
  
    public static void main(String[] args) {
      String s1 = "qwertybim";
      String s2 = "qwebritmy";
      var r = Lmp(s1, s2);
      System.out.println(r);
    }
  }
