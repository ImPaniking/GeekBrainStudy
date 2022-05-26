﻿//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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

string printArray(int[] array){
    System.Text.StringBuilder result = new System.Text.StringBuilder();
    for (int i = 0; i < array.Length; i++){
        if ((i == 0) && (array.Length > 1) )
            result.Append("[").Append(array[i]).Append(", ");
        else if ((i == 0) && (array.Length == 1) ) 
            result.Append("[").Append(array[i]).Append("]");
        else if ( i < array.Length -1 )
            result.Append(array[i]).Append(", ");
        else 
            result.Append(array[i]).Append("]");
    }
return result.ToString();
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
        else if (i == array.Length-1)
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
"Найдите разницу между максимальным и минимальным элементов массива.\n"+
"\n\t * при выполнении заметил что может быть несколько минимальных и максимальных значений"+
"\n\t * по этому отмечаю что данная задача делается по 1 Min и 1 Max"+
"\n");

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

int min =0;
int max = 0;

(min,max) = minAndMaxOfArray(array);

/*Console.WriteLine($"\n{printArray(array)} - > min={min} , max={max} , max - min = {max-min}");*/
Console.Write("\n");
printColoredMinMax(array);
Console.Write(" - > min=");
Console.BackgroundColor = ConsoleColor.Green;
Console.Write(min);
Console.ResetColor();
Console.Write(" , max=");
Console.BackgroundColor = ConsoleColor.Yellow;
Console.Write(max);
Console.ResetColor();
Console.Write($" , max - min = {max-min}");
Console.ReadLine();