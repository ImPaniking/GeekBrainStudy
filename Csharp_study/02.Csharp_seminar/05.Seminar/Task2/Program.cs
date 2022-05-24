//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
System.Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.Clear();

int[] arrayCreation(int length){
    int[] arr = new int[length];
    Random rnd = new Random();
    for ( int i = 0 ; i< length ; i ++){
        arr[i] = rnd.Next(-9,10);
    }
return arr;}

int[] zamena(int[] array){
   for ( int i = 0; i< array.Length;i++){
      array[i] *=-1;
   }
return array;}

void printArray(int[] array){
    foreach(int item in array){
        Console.Write($"{item,2} ");
    }
}

int[] array = arrayCreation(10);
Console.WriteLine("Оригинальный массив : ");
printArray(array);
Console.WriteLine();
Console.WriteLine("Новый массив ");
printArray(zamena(array));