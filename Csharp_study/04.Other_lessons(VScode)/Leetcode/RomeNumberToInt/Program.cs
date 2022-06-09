//Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M

//Symbol Value
//I             1
//V             5
//X             10
//L             50
//C             100
//D             500
//M             1000

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

var RomeNumbers = new Dictionary<string, int>()
{
    {"I",1},
    {"V",5},
    {"X",10},
    {"L",50},
    {"C",100},
    {"D",500},
    {"M",1000}
};

Console.Write("Введите число римскими буквами : ");
string romeNumber = Console.ReadLine();
int result = 0;
for ( int i = 0 ; i < romeNumber.Length ; i++)
{
    if ( i == romeNumber.Length-1 ) result += RomeNumbers[$"{romeNumber[i]}"];
    else 
    {
        if (RomeNumbers[$"{romeNumber[i]}"]<RomeNumbers[$"{romeNumber[i+1]}"])
        {
            result += RomeNumbers[$"{romeNumber[i+1]}"]-RomeNumbers[$"{romeNumber[i]}"];
            i++;
        } 
    else result += RomeNumbers[$"{romeNumber[i]}"];
    } 
}
Console.WriteLine($"{romeNumber} - > {result}");    

