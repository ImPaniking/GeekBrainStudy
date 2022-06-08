//Задача составить слова из букв

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();
int n = 0;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
        Console.WriteLine($"{n++} {new String(word)}"); return;
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

int k = 5;

FindWords("аисв", new char[k]);