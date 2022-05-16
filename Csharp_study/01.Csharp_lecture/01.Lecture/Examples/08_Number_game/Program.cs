Console.Clear();
Console.WriteLine("Game - GUESS NOMBER! =)");

Console.Write("Enter your name :");
string UserName = Console.ReadLine();
Console.WriteLine($"Hi, {UserName} - here are Game Rules:");

int MinNumber = 1;
int MaxNumber = 100;
Console.WriteLine($"Comuter had chosen a random number between {MinNumber} and {MaxNumber}");
Console.WriteLine("You should choose difficulty, wich give's you an ammount of turns: ");
Console.WriteLine("5 - Easy 50 turns");
Console.WriteLine("4 - Easy 35 turns");
Console.WriteLine("3 - Easy 10 turns");
Console.WriteLine("2 - Easy 5 turns");
Console.WriteLine("1 - Easy 3 turns");

Console.Write("Chouse difficulty : ");
var DifficultyLevels = new Dictionary<string,int>()
{
    {"1", 3},
    {"2", 5},
    {"3", 10},
    {"4", 35},
    {"5", 50},
};
string Difficulty = Console.ReadLine();
int DifficultyLevel = DifficultyLevels[Difficulty];
Console.WriteLine($"And the game BEGINS! You need to guess the number in {DifficultyLevel} , turns");

int CompNumber = new Random().Next(MinNumber,MaxNumber);
int PlayerNumber = 0; 
int TurnCount = 0;

while (PlayerNumber != CompNumber)
{
    TurnCount++;
    if (TurnCount == DifficultyLevel+1) 
    {
        Console.WriteLine("You don't have more Turns...Sorry, you Lose =(");
        break;
    }
    else
    {
        Console.Write("Enter you'r number : ");
        PlayerNumber = Convert.ToInt32(Console.ReadLine());

        if (PlayerNumber == CompNumber)
        {
            Console.WriteLine("WOW!");
            Console.WriteLine($"Congratulation {UserName}! You WON in {TurnCount} tunrs");
        }
        else if (PlayerNumber < CompNumber) 
        {
            if (TurnCount == DifficultyLevel) Console.WriteLine($"Oops, the number was {CompNumber}");
            
            else Console.WriteLine("Try a higher number");
        }
        else 
        {
            if (TurnCount == DifficultyLevel) Console.WriteLine($"Oops, the number was {CompNumber}");
            
            else Console.WriteLine("Try a lower number");
        }
    }
}