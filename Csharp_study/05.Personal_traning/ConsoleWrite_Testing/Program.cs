System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int number = 100;
double minutes = 60.5D;

Console.WriteLine($"Записать цифру с автоматическим форматирование в местную валуюту \n\t{number:C}");
Console.WriteLine($"Записать цифру с n знаками после запятой \n\t{number:N1}");
Console.WriteLine(
$"Записать цифру в формате \n"+
$"\t Число {number}\n"+
$"\t формат X {number:X}\n"+
$"\t формат E {number:E}\n"+
$"\t формат C0 {number:C0}\n"+
$"\t формат N число с 2 знаками после запятой{number:N}\n"+
$"\t формат C4 деньги {number:C4}\n"+
$"\t формат G градус {number:G}\n"+
$"\t формат F фаренгейт ?{number:F1}\n");

/*double cost = 1632.54;
Console.WriteLine(cost.ToString("C",new System.Globalization.CultureInfo("en-US")));
Console.WriteLine(cost.ToString("C",new System.Globalization.CultureInfo("en-EU")));
Console.WriteLine(cost.ToString("C",new System.Globalization.CultureInfo("en-GB")));
Console.WriteLine(cost.ToString("C",new System.Globalization.CultureInfo("en-RU")));
Console.WriteLine(cost.ToString("C",new System.Globalization.CultureInfo("en-MD")));
Console.WriteLine(cost.ToString("C",new System.Globalization.CultureInfo("en-RO")));*/

/*Console.WriteLine($"{23.5m}"+"°C");*/

/*Console.WriteLine("\n Крутая штучка - присвоения формата записи");
DayOfWeek thisDay = DayOfWeek.Monday;
string[] formatStrings = {"G", "F", "D", "X"};

foreach (string formatString in formatStrings)
   Console.WriteLine(thisDay.ToString(formatString));*/
   
/*Console.WriteLine("\n Другая Крутая штучка - присвоения формата записи");
byte[] byteValues = { 12, 163, 255 };
foreach (byte byteValue in byteValues)
   Console.WriteLine(byteValue.ToString("X4"));
foreach (byte byteValue in byteValues)
   Console.WriteLine(byteValue.ToString("N2"));
foreach (byte byteValue in byteValues)
   Console.WriteLine(byteValue.ToString("C",new System.Globalization.CultureInfo("en-MD")));*/