//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Random rnd = new Random();

int numberInput(string str){//Метод ввода и проверки на число
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt){
        Console.Write(str);
        string numberSTR = Console.ReadLine();
        if (int.TryParse(numberSTR, out int numberInt) ){//проверка на число
            number = numberInt;
            readlineFromStrToInt = false;}} 
return number;}

int[] randomArrayCreation(int length,int minRnd,int maxRnd){//Метод создания массива с заданным размером и случайными числами в заданном диапазоне
    if (length < 0 ) {
         Console.WriteLine($"Массив по минусу {length} не может быть создан, беру по модулу {-length}"); 
         length *= -1;} 
    int[] array = new int[length];
    if (minRnd > maxRnd) {
        Console.WriteLine("Перепутаны Min и Max, меняю местами");
        int temp = maxRnd;
        maxRnd = minRnd;
        minRnd = temp;    }
    else if (minRnd == maxRnd && length != 0 ) Console.WriteLine($"В рандоме всего 1 значение {minRnd}");
    for (int i = 0; i< array.Length;i++) array[i] = rnd.Next(minRnd,maxRnd+1);
return array;
}

void printArrayNumb(int[] array){//Метод печати массива - как набор цифр
    for (int i =0 ; i < array.Length; i++){
        Console.Write(array[i]);
        if (i < array.Length-1) Console.Write(", ");
    } 
}

void printArray(int[] array){//Метод печати массива - как массив
    for (int i =0 ; i < array.Length; i++){
        if (i ==0 ) Console.Write("[");
        Console.Write(array[i]);
        if (i < array.Length-1) Console.Write(", ");
        else Console.Write("]");
    } 
}

void FullPrint(int[] array){//Метод объединения печати 2х вариантв - для задания
    Console.Write("\n");
    if (array.Length == 0 ) Console.WriteLine("\tГоворят, если долго смотреть в пустоту,\n\t пустота начнёт смотреть на тебя");
    else {
        printArrayNumb(array);
        Console.Write(" -> ");
        printArray(array);}
        Console.WriteLine("\n\n"); 
}

int[] fullRandomArray(){//Метод Создания случайного массива длиной от 5 до 50 и случайными цифрами от 0 до 999
    int[] array = new int[rnd.Next(5,51)];
    for (int i =0; i< array.Length; i++) array[i] = rnd.Next(0,1000);
return array;}

string choiceBut(){// метод вывода кнопки кнопки из 3х вариантов
    ConsoleKeyInfo cki;
    Console.WriteLine("Есть 3 варианта создать массив :"+ 
    "\nКнопка 'N' - создание массива с указанием размера и диапозоном чисел"+
    "\nКнопка 'R' - Создание случайного массива длиной от 5 до 49 и случайными цифрами от 0 до 999"+
    "\nКнопка 'H' - Ручной ввод маасива");
    do{
        cki = Console.ReadKey(true);
    }while (cki.Key != ConsoleKey.N && cki.Key != ConsoleKey.R && cki.Key != ConsoleKey.H );
return Convert.ToString(cki.Key);}

void choicenButPrint(string but){// метод описания что было выбрано - чисто для красоты
    if (but == "N") Console.WriteLine("\t Выбран вариант с указанием праметров нового массива ");
    if (but == "R") Console.WriteLine("\t Выбран вариант где создаётся случайный массив размером 5-49 и случайными числами 0-999 ");
    if (but == "W") Console.WriteLine("\t Выбран вариант с ручным вводом каждого числа : ");
}

int[] arrayCreation(){// метод создания массива через список
    List<int> list= new List<int>();
    int index = 1;
    Console.WriteLine("Вводите числа через ENTER. Когда закончите , нажмите Q");
    do{
        Console.Clear();
        list.Add(numberInput($"Число.{index}: "));
        index++;
        Console.Write("Q - exti/Enter - next");
    } while (Console.ReadKey().Key != ConsoleKey.Q);
    int[] array = (convertListToArray(list));
return array;}

int[] convertListToArray(List<int> list){// метод создания массива через список - это тут только потому что в задаче сказанно массив , можно было бы и на списке закончить
    int[] array = new int[list.Count];
    for (int i = 0; i < list.Count; i++) array[i] = list[i];
return array;}

System.Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.Clear();
Console.WriteLine("Задача 29:\n"+
"\tНапишите программу, которая задаёт массив из 8 элементов \n"+
"\tи выводит их на экран.\n"+
"\tПример: 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] -- *нажмите Enter для продолжения");
Console.ReadLine();
string choicenButton = String.Empty;

do{
Console.Clear();

choicenButton = choiceBut();
Console.Clear();
choicenButPrint(choicenButton);
switch (choicenButton){
    case "N":
        FullPrint(
            randomArrayCreation(
                numberInput("Введите размер массива : "),
                numberInput("Введите минимальное случайное число : "),
                numberInput("Введите максимальное случайное число : ")));
        break;
    case "R":
        FullPrint(
            fullRandomArray());
        break;
    case "H":
        FullPrint(
            arrayCreation());
        break;
}

Console.WriteLine("Для выходна, нажмите ESCAPE, люба другая кнопка запустить программу повторно.");
} while (Console.ReadKey().Key != ConsoleKey.Escape);