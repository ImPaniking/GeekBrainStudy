Console.Clear();

Console.WriteLine("Задача 21:\n Напишите программу, которая принимает на вход координаты двух точек\n и находит расстояние между ними в 3D пространстве.");

/* Способ решения через массив*/

/* Метод проверки ввода*/
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

/* Метод указания какая координата вводится*/
void writeWhatCoord(int i, int j){
    if ((j == 0)) Console.Write($"\t X{i+1} : ");
    else if ((j == 1)) Console.Write($"\t Y{i+1} : ");
    else  Console.Write($"\t Z{i+1} : ");
}

/* Метод ввода кординат*/
int[,] CoordEnter(){
    int[,] array = new int[2,3];
    for (int i = 0; i < 2; i++){
        Console.WriteLine($"Coodinate {i+1} : ");
        for (int j = 0; j < 3; j++){
            writeWhatCoord(i,j);
            array[i,j] = EnterNumberTest();
        }
    }
return array;
}
/* Метод ввода кординат, универсальный
int[,] CoordEnter(int coordCount, int ploskosti){
    int[,] array = new int[coordCount,ploskosti];
    for (int i = 0; i < coordCount; i++){
        for (int j = 0; j < ploskosti; j++){
            writeWhatCoord(i,j);
            array[i,j] = EnterNumberTest();
        }
    }
return array;
}*/

/* Метод рассчёта длины отрезка через 2 точки в 3д плоскости*/
double lengtCount(int[,] array){
    double d = (double)Math.Sqrt(Math.Pow(array[1,0]-array[0,0] , 2)+Math.Pow(array[1,1]-array[0,1] , 2)+Math.Pow(array[1,2]-array[0,2] , 2));
return d;
}
/* Тело программы*/
int[,] array = CoordEnter();

Console.WriteLine($"Length = {lengtCount(array):N2}");

Console.ReadLine();