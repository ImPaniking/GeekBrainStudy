Console.Clear();

Console.WriteLine("Задача 3:\n Напишите программу, которая выводит третью цифру заданного числа\n или сообщает, что третьей цифры нет.");

/* При тестировании заметил что если число очень больше , вне диапазона int , выскочил текст как будто ввели не число.
    Пока не стал в это вникать, предполагаю что нужно проверку делать не через int а через ulong , но что бы не нагржать систему
    Второй этап проверки - входил ли числов в int и если нет, повторять цикл пока не войдёт в диапозон */
int EnterNumberTest(){
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt){
        Console.Write("Введите число : ");
        string numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) ){
            number = numberInt;
            readlineFromStrToInt = false;
        }
        else Console.WriteLine("Ввели не число , повторите попытку");
    }
    return number;
}

string number = Convert.ToString(EnterNumberTest());

/* Варинат 1 - простой через строку ( можно вывести в функции, но пока просто над концепцией работаю), добавил проверку на отрицательное число */
if (number[0] == '-'){
    if (number.Length >=4) Console.WriteLine($"{number} - > {number[3]}");
    else Console.WriteLine($" {number} - > нет 3го числа");
}
else{
    if (number.Length >=3) Console.WriteLine($"{number} - > {number[2]}");
    else Console.WriteLine($" {number} - > нет 3го числа");
}


/* Варинат 2 - вариант через число . Несколько лишних шагов, так как вверху уже ввёл переменную string number и не хотел плодить море переменных */
int numberInt = Convert.ToInt32(number);
int lookUpNumber = 0;
if((numberInt > -100) && (numberInt <100)) Console.WriteLine($" {number} - > нет 3го числа");
else if (numberInt <= -100)
{
    lookUpNumber = int.Parse(Convert.ToString(number[3]));
    Console.WriteLine($"{number} - > {lookUpNumber}");
} 
else{
    lookUpNumber = int.Parse(Convert.ToString(number[2]));
    Console.WriteLine($"{number} - > {lookUpNumber}");
} 

Console.ReadLine();

