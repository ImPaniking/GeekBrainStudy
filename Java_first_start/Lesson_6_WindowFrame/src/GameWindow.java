import javax.swing.*;
import java.awt.*;

public class GameWindow extends JFrame
{
    private static GameWindow game_window;

    public static void main(String[] args)
    {
        game_window = new GameWindow();//создание переменной
        game_window.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);//Указание что при закрытии окна, закрывается программа
        game_window.setLocation(200,100);//Задаём точку старта окна в Pix
        game_window.setSize(906,478);// Задаём размер окна
        game_window.setResizable(false);//Задаём - что не возможно изменить размер окна
        GameField game_field = new GameField();
        game_window.add(game_field);
        game_window.setVisible(true);//Задаём - что окно видимо
    }
    private static void onRepaint(Graphics g)
    {
        g.fillOval(10,10,200,100);
        g.drawLine(100,100,400,400);
    }
    private static class GameField extends JPanel
    {
        @Override
        protected void paintComponent(Graphics g)
        {
            super.paintComponent(g);
            onRepaint(g);
        }
    }
}