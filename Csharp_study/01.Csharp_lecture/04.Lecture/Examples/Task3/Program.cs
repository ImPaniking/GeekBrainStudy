System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

void printMatrix(int[,] mat){
    for (int i = 0; i < mat.GetLength(0); i++){
        for (int j = 0; j < mat.GetLength(1); j++){
            colorPrint(mat[i,j]);
        }
    Console.WriteLine();
    }
}
void colorPrint(int number){
    switch (number){
        case 1:
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write((char)9608);
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write((char)9608);
            break;
        case 3:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write((char)9608);
            break;
        case 4:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write((char)9608);
            break;
        case 5:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write((char)9608);
            break;
        case 6:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write((char)9608);
            break;
        case 7:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write((char)9608);
            break;
        case 8:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write((char)9608);
            break;
        default:
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write((char)9608);
            break;
    }
Console.ForegroundColor = ConsoleColor.White;
}

int[,] randomGraf(int row,int col, int minRND, int maxRND){
    Random rnd = new Random();
    int[,] mat = new int[row,col];
    for (int i = 0; i < mat.GetLength(0); i ++){
        for (int j = 0; j < mat.GetLength(1); j ++){
            mat[i,j] = rnd.Next(minRND,maxRND);
        }
    }
return mat;
}

printMatrix(randomGraf(25,150,5,9));//рандомный наборо цветных квадратиков
Console.WriteLine("Конец");