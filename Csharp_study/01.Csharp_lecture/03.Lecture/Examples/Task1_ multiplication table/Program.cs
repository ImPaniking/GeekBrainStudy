/*Создаём таблицу умножения, используя цикл For*/
Console.Clear();
void headPrint(int start, int end){/*Печать заголовка*/
    for (int i = start;i <= end;i++) Console.Write($"{$"{i} multi",-9}\t");
    Console.WriteLine();
}
void dotsPrint(int start, int end){/*Печать прослойки*/
    for (int i = start;i <= end;i++) Console.Write($"{$"********",-9}\t");
    Console.WriteLine();
}
void multTableCreate(){/*Метод таблицы умножения*/
    headPrint(1,10);
    dotsPrint(1,10);
    for (int i = 1; i<=10 ; i++){
        for (int j = 1; j <=10 ; j++){
            Console.Write($"{j,-2}x{i,-2}={j*i,-3}\t");
        }
    Console.WriteLine();
    }
}

multTableCreate();