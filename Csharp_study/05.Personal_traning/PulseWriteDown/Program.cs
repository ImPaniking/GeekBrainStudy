System.Console.OutputEncoding = System.Text.Encoding.Unicode; 
Console.Clear(); 

DateTime Date;
DateTime MidDay = new DateTime(2022,05,01,12,0,0);
int upHeartBeat;
int downHeartBeat;
int pulse;
string commit;
string MorningAfternoon = String.Empty;

/*List<DateTime,DateTime,int,int,int,string> pulseTable = new List<DateTime,DateTime,int,int,int,string>();*/
Console.Write("Дата : ");
Date = DateTime.Now;
Console.Write($"{Date:d}\n");
Console.Write("Верхнее давление : ");
upHeartBeat = int.Parse(Console.ReadLine());
Console.Write("Нижнее давление : ");
downHeartBeat = int.Parse(Console.ReadLine());
Console.Write("Пульс : ");
pulse = int.Parse(Console.ReadLine());
Console.Write("Комментарий : ");
commit = Console.ReadLine();
if (Date.TimeOfDay < MidDay.TimeOfDay) MorningAfternoon = "Y";
else MorningAfternoon = "B";

System.Text.StringBuilder result = new System.Text.StringBuilder();
result.Append($"{Date:d}").Append(";").Append($"{Date:t}").Append(";").Append(upHeartBeat).Append(";").Append(downHeartBeat).Append(";").Append(pulse).Append(";").Append(commit).Append(";").Append(MorningAfternoon);
Console.WriteLine(result);

using StreamWriter file = new("WriteLines.txt", append: true);
await file.WriteLineAsync(result.ToString());