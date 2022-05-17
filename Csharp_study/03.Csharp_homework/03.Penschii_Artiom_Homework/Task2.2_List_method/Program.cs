Console.Clear();

Console.WriteLine("Задача 21:\n Напишите программу, которая принимает на вход координаты двух точек\n и находит расстояние между ними в 3D пространстве.");

/* Способ решения через список*/

/* Метод проверки ввода */

int EnterNumberTest(){
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt){
        string numberSTR = Console.ReadLine();
        if (int.TryParse(numberSTR, out int numberInt) ){
            number = numberInt;
            readlineFromStrToInt = false;
        }
        else Console.Write("Вы ввели текст, введите пожалуйста число : "); 
    }
    return number;
}

/* Метод создания списка. Пока что на 2 точки, но можно легко исправить на N точке лишь добавив в метод N и в for i<n*/
List<(int,int,int)> coordEnter(){
    List<(int,int,int)> coodrinates = new List<(int,int,int)>();
    int x = 0;
    int y = 0;
    int z = 0;
    for (int i = 0; i< 2; i++){
        Console.Write($"Введите точку {i+1} X :");
        x = EnterNumberTest();
        Console.Write($"Введите точку {i+1} Y :");
        y = EnterNumberTest();
        Console.Write($"Введите точку {i+1} Z :");
        z = EnterNumberTest();
        coodrinates.Add((x,y,z));
        Console.WriteLine();
    }
return coodrinates;
}

/* Метод рассчёта длины по 2м точкам в 3d*/

double lengthCount(List<(int,int,int)> coodrinates){
    double d = (double)Math.Sqrt(Math.Pow(coodrinates[0].Item1-coodrinates[1].Item1 , 2)+Math.Pow(coodrinates[0].Item2-coodrinates[1].Item2 , 2)+Math.Pow(coodrinates[0].Item3-coodrinates[1].Item3 , 2));
return d;
}
  
/* Сама программа */
List<(int,int,int)> coodrinates = coordEnter();

Console.WriteLine($"Length between Coord1{coodrinates[0]} & Coord2{coodrinates[1]} = {lengthCount(coodrinates):N2}") ;

Console.ReadLine();