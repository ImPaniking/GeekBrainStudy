System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

Random rnd = new Random();

char[,] table = new char[10,10];

for (int i = 0; i < table.GetLength(0); i++){
    for (int j = 0; j < table.GetLength(1); j++){
        table[i,j] = (char)rnd.Next(65,91);
    }
}

for (int i = 0; i < table.GetLength(0); i++){
    for (int j = 0; j < table.GetLength(1); j++){
        Console.Write($"{table[i,j]} ");
    }
    Console.WriteLine();
}