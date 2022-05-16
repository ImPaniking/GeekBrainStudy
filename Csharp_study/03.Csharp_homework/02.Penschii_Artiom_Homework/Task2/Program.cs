Console.Clear();

Console.WriteLine("Задача 2:\n Напишите программу, которая выводит случайное трёхзначное число\n и удаляет вторую цифру этого числа.");
Random rnd = new Random();

string numberSTR = Convert.ToString(rnd.Next(100,1000));

/* Вариант 1 - создание числа number */ 
int number = Convert.ToInt32(Convert.ToString(numberSTR[0])+Convert.ToString(numberSTR[2]));
Console.WriteLine($"{numberSTR} - > {number}");

/* Вариант 2 - если нужно просто вывести текст */ 
Console.WriteLine($"{numberSTR} - > {Convert.ToString(numberSTR[0])+Convert.ToString(numberSTR[2])}");

/* Вариант 3 - создание функции */ 

void writeNeededSymbols(string number,int firstCharPossition, int secondCharPossition){
    int i =0;
    Console.Write($"{number} - > ");
    foreach (char numberChar in number){
        if ((i == firstCharPossition-1) || (i == secondCharPossition-1)) Console.Write(numberChar);
        i++;
    }
}
/* Принимает на вход текстовую переменную и выводит символ в данном случае первый и третий */ 
writeNeededSymbols(numberSTR,1,3);

Console.ReadLine();