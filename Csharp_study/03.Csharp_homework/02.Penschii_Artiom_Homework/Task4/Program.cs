Console.Clear();

Console.WriteLine("Задача 4:\n Напишите программу, которая принимает на вход цифру,\n обозначающую день недели, и проверяет,\n является ли этот день выходным. ");

int EnterNumberTest(){
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt){
        Console.Write("Введите число : ");
        string numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) ){
            number = numberInt;
            if (number > 7 || number < 1) Console.WriteLine("Нет такого дня недели, нужно было ввести от 1 до 7");
            else readlineFromStrToInt = false;
        }
        else Console.WriteLine("Ввели не число , повторите попытку");
    }
    return number;
}

int number = EnterNumberTest();
/* Вариант 1 - через if */
if (number == 7 || number == 6) Console.WriteLine($"{number} - > ДА! это выходной!");
else Console.WriteLine($"{number} - > Нет, ещё не выходной  ");

/* Для дленеия вывода*/
Console.Write("\n\n");
/* вариант 2 - через Switch case (в данном случае долго, но попробовать стоит)*/
switch (number){
    case 6:
        Console.Write($"{number} - > Да ");
        break; 
    case 7:
        Console.Write($"{number} - > Да ");
        break;  
    default:
        Console.Write($"{number} - > Нет ");
        break;        
}

/* Для дленеия вывода*/
Console.Write("\n\n");
/* вариант 2.2 - через Switch case or То же что и ввеху, но понял как используется or*/
switch (number){
    case 6:
    case 7:
        Console.Write($"{number} - > Да ");
        break;  
    default:
        Console.Write($"{number} - > Нет ");
        break;        
}


/* Для дленеия вывода*/
Console.Write("\n\n");
/* вариант 3 - тернаярная операция ( проба )*/

string result = (number == 6 || number == 7)? $"{number} - > ДА" : $"{number} - > Нет";
Console.WriteLine(result);

Console.ReadLine();