//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"

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

string NumbersBetwenMandN(int numberM, int numberN ) // на примере лекции 7 
{
    return numberM<=numberN? $"{NumbersBetwenMandN(numberM,numberN-1)} " + $"{numberN} ": "";
}
string NumbersBetwenNandM(int numberM, int numberN ) // обратная функция
{
    return numberM>=numberN?  $"{numberM} "+$"{NumbersBetwenNandM(numberM-1,numberN)} " : "";
}

Console.Write("Задача 64:"+
"\nЗадайте значения M и N."+
"\nНапишите программу, которая выведет все натуральные числа в промежутке от M до N.\n");

int numberM = NumberInput("число M");
int numberN = NumberInput("число N");

if (numberM < numberN) Console.Write($"M = {numberM}; N = {numberN}. -> {NumbersBetwenMandN(numberM,numberN)}\n");
else Console.Write($"M = {numberM}; N = {numberN}. -> {NumbersBetwenNandM(numberM,numberN)}");

