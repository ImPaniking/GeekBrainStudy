//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
1. Создать массив случайных 3х значных цифр.
    1.1 Размер массива утсановлю на 10
    1.2 Случайнче числы от 100 до 1000
2. Создать метод подсчёта чётных чисел.
3. Создать метод вывода массива.
*/

System.Console.OutputEncoding = System.Text.Encoding.Unicode; // Данная функция нужна мне для ноутбука что бы писались русские символы в консоли
Console.Clear(); // очистка консали - персональное предпочтение

int [] arrayCreation(int length){
    Random rnd= new Random ();//подключаем рандом
    int[] array = new int[length];//создаём массив
    for (int i = 0; i< array.Length; i++){//создаём цикл прохода по всему массиву
        array[i] = rnd.Next(100,1000);//присвоение каждому эллементу массиву 
    }
return array;
}

int evenCountInArray(int[] array){ // метод поиска чётных значений
    int count = 0;
    foreach (int item in array){
        if (item % 2 == 0)
            count++;
    }
return count;
}

string printArray(int[] array){// метод печати массива - что бы он выглядел красиво оформленным 
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++){
        if (i == 0 )
            result = "["+Convert.ToString(array[i])+", ";
        else if ( i < array.Length -1 )
            result = result +Convert.ToString(array[i])+", ";
        else 
            result = result +Convert.ToString(array[i])+ "]";
    }
return result;
}

Console.WriteLine("Задача 34:\n"+
"Задайте массив заполненный случайными положительными трёхзначными числами.\n"+
"Напишите программу, которая покажет количество чётных чисел в массиве.\n");

int arrayLength = 10;// в залаче не сказанна длина массива. Указал 10. 

int[] array = arrayCreation(arrayLength);
Console.WriteLine($"{printArray(array)} - > {evenCountInArray(array)}");
