public class task {
    public static void main(String[] args) {
        int[] a = new int[]{0};
        int[] b = new int[]{1, 2, 2, 3, 0, 7, 8, 9};
        int[] max_array = new int[]{};
        for (int l = 0; l < a.length; l++) {
            int k = 0;
            int[] c = new int[]{};
            for (int i = l; i < a.length; i++) {
                for (int j = k; j < b.length; j++) {
                    if (a[i] == b[j]) {
                        c = add_new(c, a[i]);
                        if (max_array.length < c.length) max_array = c;
                        System.out.println(b[j]);
                        k = j + 1;
                        break;
                    }
                }
            }
            System.out.println();
        }

        for (int l = 0; l < b.length; l++) {
            int k = 0;
            int[] c = new int[]{};
            for (int i = l; i < b.length; i++) {
                for (int j = k; j < a.length; j++) {
                    if (b[i] == a[j]) {
                        c = add_new(c, b[i]);
                        if (max_array.length < c.length) max_array = c;
                        System.out.printf("-> %d\n", a[j]);
                        k = j + 1;
                        break;
                    }

                }
            }
            System.out.println();
        }
        for (int i = 0; i < max_array.length; i++) {
            System.out.printf("%d ", max_array[i]);
        }
    }

    public static int[] add_new(int[] array, int el) {
        int len = array.length;
        int[] new_array = new int[len + 1];
        for (int i = 0; i < len; i++) {
            new_array[i] = array[i];
        }
        new_array[len] = el;
        return new_array;
    }
}