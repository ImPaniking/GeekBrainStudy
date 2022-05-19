System.Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.Clear();

int count = 0;

List<int> charList = new List<int>();

for (int i = 0; i < 10000; i++){
    if ((count == 8) || (count == 9) || (count == 10) || (count == 13) || ((count >= 128) && (count <= 157)) ) count++;
    else{
        charList.Add(count);
        count++;}
}
for (int i = 0; i< 100; i++){
    for ( int j = 0; j<10 ; j++) 
        Console.Write($"|{charList[int.Parse(Convert.ToString(i)+Convert.ToString(j))],-4}|{(char)charList[int.Parse(Convert.ToString(j)+Convert.ToString(i))],1}|");
    Console.WriteLine();    
}

    
        
    