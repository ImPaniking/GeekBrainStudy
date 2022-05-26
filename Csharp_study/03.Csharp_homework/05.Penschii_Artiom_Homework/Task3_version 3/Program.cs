//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
1. Создать массив случайных цифр.
2. Создать метод выявления минимального и максимального эллемента массива.
3. Создать метод вывода массива.
4. Метод Ввода числового значения
    4.1 Универсальный метод для Размера массива и Диапозона минимального и максимального значения случайных чисел
*/
System.Console.OutputEncoding = System.Text.Encoding.Unicode; 
Console.Clear(); 

int [] arrayCreation(int length,int minNumber,int maxNumber){
    Random rnd= new Random ();
    int[] array = new int[length];
    for (int i = 0; i< array.Length; i++){
        array[i] = rnd.Next(minNumber,maxNumber); 
    }
return array;
}

(int,int) minAndMaxOfArray(int[] array){ // метод поиска минимального и максимального значения
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++){
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }
return (min,max);
}

(List<int>,List<int>) allMinMaxFormArray(int[] array)
{
    List<int> minList = new List<int>();
    List<int> maxList = new List<int>();
    (int min, int max) = minAndMaxOfArray(array);
    foreach(int number in array)
    {
        if (number == min)
            minList.Add(number);
        if (number == max)
            maxList.Add(number);
    }
return (minList,maxList);
}

int differenceMaxMin(int[] array)
{
    (List<int> minL,List<int> maxL) = allMinMaxFormArray(array);
    int minSum = 0;
    int maxSum = 0;
    int diff = 0;
    foreach(int num in minL)
        minSum += num;
    foreach(int num in maxL)
        maxSum += num;
    diff = maxSum-minSum;
return diff;
}

void printColoredMinMax(int[] array)
{
    (int min,int max) = minAndMaxOfArray(array);
    Console.Write("[");
    for ( int i = 0 ; i < array.Length ; i++)
    {
        if (array[i] == min )
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(array[i]);
            Console.ResetColor();
        }
        else if (array[i] == max )
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(array[i]);
            Console.ResetColor();
        }
        else 
            Console.Write(array[i]);
        if (i < array.Length-1)
            Console.Write(", ");
        else
            Console.Write("]");
    }
}

void printList(List<int> list)
{
    Console.Write("[");
    for (int i = 0 ; i < list.Count; i++)
    {
        Console.Write(list[i]);
        if (i < list.Count - 1)
            Console.Write(", ");
        else
            Console.Write("]");
    }
}

int numberInput(string TextToWriteBeforeInput, string forArrayLengthOrForRandom){//Желание вставить весь ввод чисел в один метод
    bool examIfStrIsInt = true;
    int number = 0;
    do{
        Console.Write($"{TextToWriteBeforeInput}");
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out int numberInt)){
            if (forArrayLengthOrForRandom == "ArrayLength"){
                if (numberInt <= 1)
                    Console.WriteLine("Длина массива не мождет быть меньше или равна 1, повторите попытку");
                else{
                    number = numberInt;
                    examIfStrIsInt = false;
                }
            }
            else {
                number = numberInt;
                examIfStrIsInt = false;
            }
        }
        else Console.WriteLine("Ввели не число, повторие попытку");
    } while (examIfStrIsInt);
return number;    
}

Console.WriteLine("Задача 34:\n"+
"Задайте массив вещественных чисел. \n"+
"Найдите разницу между максимальным и минимальным элементов массива.\n");

// Так как метод ввода и проверки на число один, решил попробовать именные переменные для проверки читабильности кода.
int arrayLength = numberInput(
    TextToWriteBeforeInput:"Введите длину массива : ",
    forArrayLengthOrForRandom:"ArrayLength");

int minNumberRandom = numberInput(
    TextToWriteBeforeInput:"Введите минимальное значение случайных чисел : ",
    forArrayLengthOrForRandom:"ForRandom");

int maxNumberRandom = numberInput(
    TextToWriteBeforeInput:"Введите максимальное значение случайных чисел : ",
    forArrayLengthOrForRandom:"ForRandom")+1;

int[] array = arrayCreation(arrayLength,minNumberRandom,maxNumberRandom);

(int min,int max) = minAndMaxOfArray(array);
(List<int> minL,List<int> maxL) = allMinMaxFormArray(array);

// Довольно трудный вариант вывода... Тот самый случай, когда нужно использовать методы

Console.Write("\n");
printColoredMinMax(array);
Console.Write("\n");
Console.Write("min=(");
Console.BackgroundColor = ConsoleColor.Green;
Console.Write(min);
Console.ResetColor();
Console.Write(") list : ");
printList(minL);
Console.Write("\n");
Console.Write("max=(");
Console.BackgroundColor = ConsoleColor.Yellow;
Console.Write(max);
Console.ResetColor();
Console.Write(") list : ");
printList(maxL);
Console.Write($"\nmaxList - minList = {differenceMaxMin(array)}");
Console.ReadLine();