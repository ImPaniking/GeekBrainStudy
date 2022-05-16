Console.Clear();
Console.WriteLine("This is a game were comuper will try to guess your NUMBER!");
Console.Write("Enter you'r name : ");
int MinNum = 1;
int MaxNum = 100;
string UserName = Console.ReadLine();
Console.WriteLine($"Hi , {UserName}, rules are simple - think a number between {MinNum} and {MaxNum}, and then help Computer guess it!");
Console.WriteLine("Use '=' if computer guessed you'r number");
Console.WriteLine("Use '+' if you'r number is higher");
Console.WriteLine("Use '-' if you'r number is lower");
Console.Write($" Are you ready {UserName} ? Press ENTER to begin!");
string start = Console.ReadLine();
string help = "";
int number = 0;
int TurnCount = 0;

while (help != "=")
{
    TurnCount++;
    number = new Random().Next(MinNum,MaxNum);
    Console.Write($"Turn-{TurnCount}) {number} : ");
    help = Console.ReadLine();
    if (help == "+") MinNum = number + 1;
    else MaxNum = number - 1;
}

Console.WriteLine($"ORALE!!!! The computer guessed {number} in {TurnCount} turns =) ");