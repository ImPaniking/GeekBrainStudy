﻿//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int NumberInput(string text)//Метод ввода и проверки на число
{
    bool isInputInt = true;
    int number =0;
    while (isInputInt)
    {
        Console.Write($"Введите {text} :");
        string numberSTR = Console.ReadLine();
        if (int.TryParse(numberSTR, out int numberInt))
        {
            number = numberInt;
            isInputInt = false;
        }
        else 
            Console.WriteLine("Ввели не число");
    }
    return number;
}

int PrintNumbersBetwenMandN(int numberM, int numberN)
{
    return  numberN >= numberM? PrintNumbersBetwenMandN(numberM,numberN-1)+numberN:0;
}
int PrintNumbersBetwenNandM(int numberM, int numberN)
{
    return  numberN <= numberM? PrintNumbersBetwenNandM(numberM-1,numberN)+numberM:0;
}

Console.Write("Задача 66:"+
"\nЗадайте значения M и N."+
"\nНапишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\n\n");

int numberM = NumberInput("число M");
int numberN = NumberInput("число N");

if (numberM<numberN) Console.Write($"\nM = {numberM}; N = {numberN}. -> {PrintNumbersBetwenMandN(numberM,numberN)}");
else Console.Write($"\nM = {numberM}; N = {numberN}. -> {PrintNumbersBetwenNandM(numberM,numberN)}");