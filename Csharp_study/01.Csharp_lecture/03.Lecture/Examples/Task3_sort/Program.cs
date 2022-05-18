/*Отсортировать массив*/
Random rnd = new Random();

List<int> randomList(int listLength,int minNumber, int maxNumber){
    List<int> list = new List<int>();
    for (int i = 0 ; i < listLength ; i++) list.Add(rnd.Next(minNumber,maxNumber+1));
return list;    
}
void printList(List<int> list){ // Метод печати списка
    for (int i = 0 ; i < list.Count ; i++){
        Console.Write($"{list[i],-2}");
        if ( i < list.Count -1) Console.Write(" , ");
    }  
    Console.WriteLine(); 
}
void printArray(int[] list){ // Метод печати массива
    for (int i = 0 ; i < list.Length ; i++){
        Console.Write($"{list[i],-2}");
        if ( i < list.Length -1) Console.Write(" , ");
    }  
    Console.WriteLine(); 
}

string printArrayAsText(int[] list){ // Метод печати массива
    string text = String.Empty;
    for (int i = 0 ; i < list.Length ; i++){
        text = text +$"{list[i],-2}";
        if ( i < list.Length -1) text = text + " , ";
    }  
return text;
}

int[] formListToMass(List<int> list){ // Метод конвертации списка в массив
    int[] array = new int[list.Count];
    for (int i = 0; i< list.Count; i++) array[i]=list[i];
return array;
}
int[] sortArrayOnePosMinMax(int[] array,int from){// Метод определяющий что менять местами от минимального к максимальному
    int[] arrayNew = array;
    int min = array[from];
    int minIndex = from;
    for (int i = (from+1); i < array.Length; i++){
        if (array[i]<min){
            min = array[i];
            minIndex = i;
        } 
    } 
    arrayNew = replace(array,from,minIndex);
return arrayNew;
}
int[] sortArrayOnePosMaxMin(int[] array,int from){// Метод определяющий что менять местами от максимального к минимальному
    int[] arrayNew = array;
    int max = array[from];
    int maxIndex = from;
    for (int i = (from+1); i < array.Length; i++){
        if (array[i]>max){
            max = array[i];
            maxIndex = i;
        } 
    } 
    arrayNew = replace(arrayNew,from,maxIndex);
return arrayNew;
}
int[] replace(int[] array,int indexWhatRep, int indexWithRep){// Метод перестановки
    int[] arrayNew = array;
    int temp = arrayNew[indexWhatRep];
    arrayNew[indexWhatRep]= arrayNew[indexWithRep];
    arrayNew[indexWithRep]=temp;
return arrayNew;
}
int[] sortArrayInc(int[] array){// Метод Сортировки от минимального к максимальному
    int[] arrayNew = array;
    for (int i = 0; i< array.Length;i++) arrayNew = sortArrayOnePosMinMax(array,i);
return arrayNew;
}
int[] sortArrayDec(int[] array){// Метод Сортировки от минимального к максимальному
    int[] arrayNew = array;
    for (int i = 0; i< array.Length;i++) array = sortArrayOnePosMaxMin(array,i);
return arrayNew;
}
int[] sortArrayEven(int[] array){
    int count =0;
    for (int i = 0; i < array.Length; i++){
        if (array[i]%2 == 0) count++;
    }
    int[] arrayNew = new int[count];
    int j =0;
    for (int i = 0; i < array.Length; i++){
        if (array[i]%2 == 0){
            arrayNew[j] = array[i];
            j++;
        } 
    }
return arrayNew;
}
int[] sortArrayNotEven(int[] array){
    int count =0;
    for (int i = 0; i < array.Length; i++){
        if (array[i]%2 != 0) count++;
    }
    int[] arrayNew = new int[count];
    int j =0;
    for (int i = 0; i < array.Length; i++){
        if (array[i]%2 != 0){
            arrayNew[j] = array[i];
            j++;
        } 
    }
return arrayNew;
}

do {
    Console.Clear();

    /*List<int> list = randomList(10,0,100);
    printList(list);*/
    
    int[] array = formListToMass(randomList(20,0,100));
    Console.WriteLine($"Изначальный массив :\n\t{printArrayAsText(array)}");
    Console.WriteLine($"Отсовртированный массив от минимального к максимальному :\n\t{printArrayAsText(sortArrayInc(array))}");
    Console.WriteLine($"Отсовртированный массив от максимального к минимальному :\n\t{printArrayAsText(sortArrayDec(array))}");
    Console.WriteLine($"Отсовртированный массив только чётные цифры :\n\t{printArrayAsText(sortArrayEven(array))}");
    Console.WriteLine($"Отсовртированный массив только чётные цифры от минимального к максимальному :\n\t{printArrayAsText(sortArrayInc(sortArrayEven(array)))}");
    Console.WriteLine($"Отсовртированный массив только Не чётные цифры :\n\t{printArrayAsText(sortArrayNotEven(array))}");
    

    Console.WriteLine("\tДля выхода нажмите ESC,\n для повторна, нажмите любую клавишу к примеру ENTER");
}
while (Console.ReadKey().Key != ConsoleKey.Escape);