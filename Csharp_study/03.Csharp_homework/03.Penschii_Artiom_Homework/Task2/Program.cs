Console.Clear();

Console.WriteLine("Задача 21:\n Напишите программу, которая принимает на вход координаты двух точек\n и находит расстояние между ними в 3D пространстве.");

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

void Test(int i, int j){
    if ( (i == 0) && (j == 0)) Console.Write(" Enter X1 : ");
    else if ( (i == 0) && (j == 1)) Console.Write(" Enter Y1 : ");
    else if ( (i == 0) && (j == 2)) Console.Write(" Enter Z1 : ");
    else if ( (i == 1) && (j == 0)) Console.Write(" Enter X2 : ");
    else if ( (i == 1) && (j == 1)) Console.Write(" Enter Y2 : ");
    else  Console.Write(" Enter Z2 : "); 
}

int[,] CoordEnter(){
    int[,] array = new int[2,3];
    for (int i = 0; i < 2; i++){
        for (int j = 0; j < 3; j++){
            Test(i,j);
            array[i,j] = EnterNumberTest();
        }
    }
return array;
}

double lengtCount(int[,] array){
    double d = (double)Math.Sqrt(Math.Pow(array[1,0]-array[0,0] , 2)+Math.Pow(array[1,1]-array[0,1] , 2)+Math.Pow(array[1,2]-array[0,2] , 2));
return d;
}

int[,] array = new int[2,2];

array = CoordEnter();

Console.WriteLine($"Length = {lengtCount(array):N2}");

Console.ReadLine();