import java.util.Random;
import java.util.Scanner;

public class Main
{
    private static Random rnd = new Random();
    private static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args)
    {
        int levelCount = 1;
        System.out.println("Guess the number ! ");
        for ( int i = 10 ; i <= 100 ; i += 45)
        {
            int numberToGuess = rnd.nextInt(0, i);
            System.out.println("Level - "+levelCount+" Computer has a random number between 0 and " + i);
            levelCount++;
            playLevel(numberToGuess);
        }
        System.out.println("That's all for today folks!");
        scanner.close();
    }
    private static void playLevel(int numberToGuess)
    {
        boolean wrongNumber = true;
        int count = 0;
        while (wrongNumber) {
            count++;
            System.out.println(count + ". Enter your guess : ");
            int inputNumber = scanner.nextInt();
            if (inputNumber == numberToGuess) {
                System.out.println("You WON! You guessed " + numberToGuess + " in " + count + " turns!");
                wrongNumber = false;
            } else if (inputNumber > numberToGuess) {
                System.out.println("Your number is over 9000!");
            } else {
                System.out.println("Those are rookie numbers");
            }
        }
    }
}