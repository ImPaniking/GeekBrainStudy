//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

System.Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.Clear();

int[] arrayCreation(int length){
    int[] arr = new int[length];
    Random rnd = new Random();
    for ( int i = 0 ; i< length ; i ++){
        arr[i] = rnd.Next(0,51);
    }
return arr;}

string PrintArray(int[] array){
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++){
        if (i == 0) result = "[ "+result + Convert.ToString(array[i]) + ", ";
        else if (i < array.Length-1)
            result = result + Convert.ToString(array[i]) + ", ";
        else result = result + Convert.ToString(array[i]) + "]";
    }
return result;
}

string PrintList(List<int> list){
    string result = String.Empty;
    for (int i = 0; i < list.Count; i++){
        if (i == 0) result = "[ "+result + Convert.ToString(list[i]) + ", ";
        else if (i < list.Count-1)
            result = result + Convert.ToString(list[i]) + ", ";
        else result = result + Convert.ToString(list[i]) + "]";
    }
return result;
}

List<int> sumNumbers(int[] array){
    List<int> list= new List<int>();
    for (int i = 0; i < array.Length/2 ; i++){
        list.Add(array[i]*array[array.Length-1-i]);
    }
return list;
}

int[] array = arrayCreation(10);
List<int> list = sumNumbers(array);

Console.WriteLine($"{PrintArray(array)}\n{PrintList(list)}");
