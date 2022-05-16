Console.Clear();
var WeekDay = new Dictionary<string,string>()
{
    {"1" , "Monday"},
    {"2" , "Tuesday"},
    {"3" , "Wensday"},
    {"4" , "Thursday"},
    {"5" , "Friday"},
    {"6" , "Saturday"},
    {"7" , "Sunday"}
};
Console.Write("Chouse from 1 to 7 : ");
string WkDay = Console.ReadLine();
Console.WriteLine(WeekDay[WkDay]);
Console.ReadKey();

Console.Write("Chouse from 1 to 7 : ");
WkDay = Console.ReadLine();
if (WkDay == "1") Console.WriteLine(" Monday ");
else if (WkDay == "2") Console.WriteLine(" Tuesday ");
else if (WkDay == "3") Console.WriteLine(" Wensday ");
else if (WkDay == "4") Console.WriteLine(" Thursday ");
else if (WkDay == "5") Console.WriteLine(" Friday ");
else if (WkDay == "6") Console.WriteLine(" Saturday ");
else Console.WriteLine(" Sunday ");