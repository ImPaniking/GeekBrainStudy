using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleGame_and_Test
{
    internal class Program
    {
        static int[] EAT()
        {
            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(10, 10);
            int eatx = new Random().Next(10, 400);
            int eaty = new Random().Next(10, 400);
            Shapes.Move(eat, eatx, eaty);
            int[] eatxy = new int[2] {eatx,eaty};
            return eatxy;

        }
        static void Main(string[] args)
        {
            int speed = 4;
            Turtle.Speed = speed;
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();
            Turtle.Speed = 9;

            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(10, 10);
            int eatx = new Random().Next(10, 400);
            int eaty = new Random().Next(10, 400);
            Shapes.Move(eat, eatx, eaty);

            while (true)
            {
                Turtle.Move(10);
                if (Turtle.X >= eatx && Turtle.X <= eatx + 10 && Turtle.Y >= eaty && Turtle.Y <= eaty + 10)
                {
                    eatx = new Random().Next(10, GraphicsWindow.Width-10);
                    eaty = new Random().Next(10, GraphicsWindow.Height-10);
                    Shapes.Move(eat, eatx, eaty);
                }

            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up") Turtle.Angle = 0;
            else if (GraphicsWindow.LastKey == "Right") Turtle.Angle = 90;
            else if (GraphicsWindow.LastKey == "Down") Turtle.Angle = 180;
            else if (GraphicsWindow.LastKey == "Left") Turtle.Angle = 270;
        }
    }
}
