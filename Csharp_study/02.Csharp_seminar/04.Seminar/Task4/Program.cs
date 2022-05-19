Console.Clear();
Random rnd = new Random();
int[] array = new int[8];

void arrayInput(int[] array){
    for (int i = 0;i<8;i++){
    array[i] = rnd.Next(0,2);
    Console.Write(array[i]);
    if (i < 7 ) Console.Write(" , ");}} 

arrayInput(array);
Console.WriteLine();
void arrayInputRandom(int length){
    int[] arrayNew = new int[length];
    for (int i = 0;i<length;i++){
    arrayNew[i] = rnd.Next(0,2);
    Console.Write(arrayNew[i]);
    if (i < 7 ) Console.Write(" , ");}}

arrayInputRandom(8);
