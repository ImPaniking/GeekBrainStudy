Console.Clear();
//Ввод переменных
int Count = 0;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
//double Distance = 10000;
int Distance = 10000;
//double Distance1 = Distance;
int Distance1 = Distance;
int Friend = 2;
//double TimeRun = 0;
int TimeRun = 0;
//Условие цикла
while (Distance > 10)
{
    if (Friend == 1)
    {
        TimeRun = Distance / (FirstFriendSpeed + DogSpeed);
        Friend = 2;
    }
    else
    {
        TimeRun = Distance / (SecondFriendSpeed + DogSpeed);
        Friend = 1;
    }
    Distance = Distance - ((FirstFriendSpeed + SecondFriendSpeed) * TimeRun);
    Count++;
    //Проверка действия собаки
    Console.WriteLine("{1} Distance between friends is {0}, dog ran it in {2}",Distance1-Distance,Count,(double)(Distance1-Distance)/DogSpeed);
    Distance1 = Distance;
}
//Вывод ответа
Console.WriteLine($"Dog ran {Count} times");
