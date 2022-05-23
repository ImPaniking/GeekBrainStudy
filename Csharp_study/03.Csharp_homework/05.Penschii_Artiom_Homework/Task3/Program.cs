//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
1. Создать массив случайных цифр.
    1.1 Размер массива утсановлю на 10
2. Создать метод выявления минимального и максимального эллемента массива.
3. Создать метод вывода массива.
*/

System.Console.OutputEncoding = System.Text.Encoding.Unicode; // Данная функция нужна мне для ноутбука что бы писались русские символы в консоли
Console.Clear(); // очистка консали - персональное предпочтение

int [] arrayCreation(int length,int minNumber,int maxNumber){
    Random rnd= new Random ();//подключаем рандом
    int[] array = new int[length];//создаём массив
    for (int i = 0; i< array.Length; i++){//создаём цикл прохода по всему массиву
        array[i] = rnd.Next(minNumber,maxNumber);//присвоение каждому эллементу массиву 
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

string printArray(int[] array){// метод печати массива - что бы он выглядел красиво оформленным 
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++){
        if (i == 0 )
            result = "["+Convert.ToString(array[i])+", ";
        else if ( i < array.Length -1 )
            result = result +Convert.ToString(array[i])+", ";
        else 
            result = result +Convert.ToString(array[i]) +"]";
    }
return result;
}

Console.WriteLine("Задача 34:\n"+
"Задайте массив вещественных чисел. \n"+
"Найдите разницу между максимальным и минимальным элементов массива.\n");

int arrayLength = 10;// в залаче не сказанна длина массива. Указал 10. 
int minNumberRandom = 0;
int maxNumberRandom = 10;

int[] array = arrayCreation(arrayLength,minNumberRandom,maxNumberRandom);

int min =0;
int max = 0;

(min,max) = minAndMaxOfArray(array);

Console.WriteLine($"{printArray(array)} - > min = {min} , max = {max} , max - min = {max-min}");
