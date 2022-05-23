//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

Console.Clear();

int[] arrayCreation(int length){
    int[] arr = new int[length];
    Random rnd = new Random();
    for ( int i = 0 ; i< length ; i ++){
        arr[i] = rnd.Next(-9,10);
    }
return arr;}

int getMinSumArray(int[] array){
    int sum = 0;
    foreach (int item in array){
        if (item<0)
            sum += item;
    }
return sum;}

int geMaxSumArray(int[] array){
    int sum = 0;
    foreach (int item in array){
        if (item>0)
            sum += item;
    }
return sum;}

void printArray(int[] array){
    foreach(int item in array){
        Console.Write($"{item} ");
    }
}

(int , int ) GetSumFormArray(int[] array){
    int sumMun = 0;
    int sumMax = 0;
    foreach ( int item in array){
        if (item>0)
            sumMax += item;
        else sumMun += item;
    }

return (sumMun,sumMax);}

int[] array = arrayCreation(12);
printArray(array);

int sum1 = getMinSumArray(array);
int sum2 = geMaxSumArray(array);

Console.WriteLine();
Console.WriteLine($"sum < 0 = {sum1} and sum > 0 {sum2}");

(sum1 , sum2) = GetSumFormArray(array);
Console.WriteLine($"sum < 0 = {sum1} and sum > 0 {sum2}");

