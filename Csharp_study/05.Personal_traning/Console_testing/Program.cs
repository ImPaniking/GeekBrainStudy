Console.Clear();
/*Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your option? ");

Console.WriteLine();

Console.WriteLine("Число\tСимвол");
for (int i = 0; i <=127; i++) Console.WriteLine($"{i}\t{Convert.ToChar(i)}");*/

/*string[,] array = {
    {"Дата","Имя","Фамилия","Должность","Время прихода","Время ухода"},
    {"-----","-----","-----","-----","-----","-----"},
    {"01/05/2022","Имя","Фамилия","Должность","Время прихода","Время ухода"},
    {"01/05/2022","Имя","Фамилия","Должность","Время прихода","Время ухода"},
    {"01/05/2022","Имя","Фамилия","Должность","Время прихода","Время ухода"},
    {"01/05/2022","Имя","Фамилия","Должность","Время прихода","Время ухода"},
    {"01/05/2022","Имя","Фамилия","Должность","Время прихода","Время ухода"},
    {"01/05/2022","Имя","Фамилия","Должность","Время прихода","Время ухода"},
    {"01/05/2022","Имя","Фамилия","Должность","Время прихода","Время ухода"},
    {"01/05/2022","Имя","Фамилия","Должность","Время прихода","Время ухода"},
    {"01/05/2022","Имя","Фамилия","Должность","Время прихода","Время ухода"},
    {"01/05/2022","Имя","Фамилия","Должность","Время прихода","Время ухода"}};

for (int i = 0; i < 10; i++)
{
    for (int n = 0; n < 6; n++)
    {
        Console.Write($"{array[i, n] , 13} \t");
    }
    Console.WriteLine();
}*/
Random rnd = new Random();

DateTime Date = new DateTime(2022, 5 , 1 , 9 , 0 , 0);

TimeSpan enterTime(){
    TimeSpan time = new TimeSpan(rnd.Next(8,10), rnd.Next(0,60), rnd.Next(0,60));
    return time;
}
TimeSpan exitTime(){
    TimeSpan time = new TimeSpan(rnd.Next(16,19), rnd.Next(0,60), rnd.Next(0,60));
    return time;
}

object[,] table = new object[34,8];
table[0,0] = "Дата";
table[0,1] = "ДеньНедели";
table[0,2] = "Имя";
table[0,3] = "Фамилия";
table[0,4] = "Должность";
table[0,5] = "Время прихода";
table[0,6] = "Время ухода";
table[0,7] = "Время";
table[1,0] = "----------";
table[1,1] = "----------";
table[1,2] = "----------";
table[1,3] = "----------";
table[1,4] = "----------";
table[1,5] = "----------";
table[1,6] = "----------";
table[1,7] = "----------";

TimeSpan enTime = new TimeSpan();
TimeSpan exTime = new TimeSpan();
TimeSpan woTime = new TimeSpan();
TimeSpan sum = new TimeSpan();

for (int i=2;i <= 32; i++){
    
    table[i,0] = (Date).ToShortDateString();
    table[i,1] = Date.DayOfWeek;
    if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday) {
        Date = Date.AddDays(1);
    }
    else {
        enTime = enterTime();
        exTime = exitTime();
        woTime = exTime - enTime;
        table[i,5] = enTime;
        table[i,6] = exTime;
        table[i,7] = woTime -new TimeSpan(1,0,0);
        Date = Date.AddDays(1);
        sum = sum + woTime;
    }      
} 

for (int i=0;i <= 32; i++){
    for (int j =0; j <= 7; j++){
        Console.Write($"{table[i,j] , -13}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\n\n\n\n\n");
Console.WriteLine($"Всего отработанно : {sum}");
Console.WriteLine($"\tВсего дней - {sum.Days}");
Console.WriteLine($"\tИтого Часов - {sum.Days*24+sum.Hours}");
Console.WriteLine($"\tИтого минут - {sum.Days*24+sum.Hours*60 +sum.Minutes}");

Console.ReadLine();

/*TimeSpan timeTest = new TimeSpan();
timeTest = Convert.ToDateTime(table[5,6]).TimeOfDay;*/


    

