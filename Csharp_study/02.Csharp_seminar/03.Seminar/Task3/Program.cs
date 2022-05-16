Console.Clear();

Console.WriteLine("Задача 1:\n Напишите программу, которая принимает на вход координаты точки (X и Y),\n причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,\n в которой находится эта точка.");

int EnterNumberTest(){
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt){
        string numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) ){
            number = numberInt;
            readlineFromStrToInt = false;
        }  
    }
    return number;
}

void Test(int i, int j){
    if ( (i == 0) && (j == 0)) Console.Write(" Enter X1 : ");
    else if ( (i == 0) && (j == 1)) Console.Write(" Enter Y1 : ");
    else if ( (i == 1) && (j == 0)) Console.Write(" Enter X2 : ");
    else  Console.Write(" Enter Y2 : "); 
}

int[,] CoordEnter(){
    int[,] array = new int[2,2];
    for (int i = 0; i < 2; i++){
        for (int j = 0; j < 2; j++){
            Test(i,j);
            array[i,j] = EnterNumberTest();
        }
    }
return array;
}

/*
void CoordPrint(int [,] array){
    for (int i = 0; i < 2; i++){
        for (int j = 0; j < 2; j++){
            Test(i,j);
            Console.WriteLine(array[i,j]);
        }
    }
}*/

int[,] array = new int[2,2];

array = CoordEnter();

/*CoordPrint(array);*/

double d = (double)Math.Sqrt(Math.Pow(array[1,0]-array[0,0] , 2)+Math.Pow(array[1,1]-array[0,1] , 2));

Console.WriteLine($"Length = {d}");