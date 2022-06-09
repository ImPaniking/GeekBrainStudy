int[] ArrayCreation(int length)
{
    Random rnd = new Random();
    int[] numbersArray = new int[length];
    for (int i = 0 ; i < length ; i++)
        numbersArray[i] = rnd.Next(0,10);
    return numbersArray;
}

string LookUpIndex(int[] array, int target)
{
    string result= "None";
    for (int i = 0 ; i < array.Length-1 ; i++)
        for ( int j = i+1 ; j < array.Length; j++)
            if (array[i]+array[j] == target)
            {
                result = $"[{i},{j}]";
                break;
            } 
    return result;   
}

int target = 6;
int[] array = ArrayCreation(10);
for (int i = 0 ; i < array.Length ; i ++)
    Console.Write($"{array[i]} ");
Console.WriteLine($"-> {LookUpIndex(array,target)} = {target}");