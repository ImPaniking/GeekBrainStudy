import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.*;
import java.io.IOException;

public class GameWindow extends JFrame
{
    private static GameWindow game_window;
    private static long last_frame_time;
    private static Image background;
    private static Image game_over;
    private static Image drop;
    private static float drop_left = 200;
    private static float drop_top = 200;

    public static void main(String[] args) throws IOException
    {
        background = ImageIO.read(GameWindow.class.getResourceAsStream("background.png"));//Подгружаем фон
        game_over = ImageIO.read(GameWindow.class.getResourceAsStream("game_over.png"));//Подгружаем надпись
        drop = ImageIO.read(GameWindow.class.getResourceAsStream("drop.png"));//Подгружаем то что будет падать

        game_window = new GameWindow();//создание переменной
        game_window.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);//Указание что при закрытии окна, закрывается программа
        game_window.setLocation(200,100);//Задаём точку старта окна в Pix
        game_window.setSize(906,478);// Задаём размер окна
        game_window.setResizable(false);//Задаём - что не возможно изменить размер окна
        last_frame_time = System.nanoTime();
        GameField game_field = new GameField();
        game_window.add(game_field);
        game_window.setVisible(true);//Задаём - что окно видимо
    }
    private static void onRepaint(Graphics g)
    {
        long current_time = System.nanoTime()
        g.drawImage(background , 0 , 0 ,null);
        g.drawImage(drop , (int)drop_left , (int)drop_top ,null);
//        g.drawImage(game_over, 280 , 120 ,null);
    }
    private static class GameField extends JPanel
    {
        @Override
        protected void paintComponent(Graphics g)
        {
            super.paintComponent(g);
            onRepaint(g);
            repaint();
        }
    }
}