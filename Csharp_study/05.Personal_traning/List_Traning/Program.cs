using System;
using System.Collections.Generic;

namespace Lists
{
    class Coordinates
    {
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    }
    class Program
    {
   public static int EnterNumberTest(int count,int coordNumber){
        bool readlineFromStrToInt = true;
        int number =0;
        while (readlineFromStrToInt){
            writeWhatCoord(coordNumber,count);
            string numberSTR = Console.ReadLine();
            if (int.TryParse(numberSTR, out int numberInt) ){
                number = numberInt;
                readlineFromStrToInt = false;
            }
            else Console.Write("Вы ввели текст, введите пожалуйста число : "); 
        }
    return number;
    }   
    public static void writeWhatCoord(int i, int j){
        if ((j == 0)) Console.Write($"\t X{i+1} : ");
        else if ((j == 1)) Console.Write($"\t Y{i+1} : ");
        else  Console.Write($"\t Z{i+1} : ");
    }

    static void PrintList(List<Coordinates> list){
        Console.WriteLine($"Coord.'s \t  X  \t  Y  \t  Z  \t");
        for(int i = 0; i < list.Count; i++){
            Console.WriteLine($"{i+1,5}   \t {list[i].X} \t {list[i].Y} \t {list[i].Z}\t");
        }  

    }
    static string PrintCoord(List<Coordinates> list , int i){
            return $"{list[i].X}:{list[i].Y}:{list[i].Z}";  
    }

    public static List<Coordinates> NewList(int length){
        List<Coordinates> listOfCoordinates = new List<Coordinates>();
        for (int i = 0;i < length;i++){
            Console.WriteLine($"Coodrinate {i+1} : ");
            listOfCoordinates.Add(new Coordinates() { X = EnterNumberTest(0,i), Y = EnterNumberTest(1,i), Z = EnterNumberTest(2,i) });
        }
    return listOfCoordinates;
    }
    static void Main(string[] args)
    {
        Console.Clear();
        List<Coordinates> coord =NewList(2);
        Console.WriteLine();
        PrintList(coord);
        Console.WriteLine();
        double d = (double)Math.Sqrt(Math.Pow(coord[0].X-coord[1].X , 2)+Math.Pow(coord[0].Y-coord[1].Y , 2)+Math.Pow(coord[0].Z-coord[1].Z , 2));

        Console.WriteLine($"Distance between coord 1({PrintCoord(coord,0)}) and coord 2({PrintCoord(coord,1)}) = {d:N2}");

        Console.ReadLine();
    }
    }
}

