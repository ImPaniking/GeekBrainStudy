ConsoleKeyInfo cki;
do
{
    Console.Clear();
    cki = Console.ReadKey(true);
    Console.Write(Convert.ToString(cki.Key));
    Console.ReadLine();
} while (cki.Key != ConsoleKey.Escape);
