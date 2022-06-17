import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scaner = new Scanner(System.in);
        /*System.out.println("Enter number : ");
        int a = scaner.nextInt();
        System.out.println("a = " + a);*/
        System.out.println("Choose operation");
        System.out.println("1. Sum (+)");
        System.out.println("2. Diff (-)");
        System.out.println("3. Multiplication (*)");
        System.out.println("4. Division (/)");
        int operation = scaner.nextInt();
        System.out.println("Enter first number : ");
        int firstNumber = scaner.nextInt();
        System.out.println("Enter second number : ");
        int secondNumber = scaner.nextInt();
        double result;
        if (operation == 1 )
        {
            result = firstNumber + secondNumber;
            System.out.println(firstNumber + " + " + secondNumber + " = " + result);
        }
        else if (operation == 2 )
        {
            result = firstNumber - secondNumber;
            System.out.println(firstNumber + " - " + secondNumber + " = " + result);
        }
        else if (operation == 3 )
        {
            result = firstNumber * secondNumber;
            System.out.println(firstNumber + " * " + secondNumber + " = " + result);
        }
        else
        {
            result = (double)firstNumber / secondNumber;
            System.out.println(firstNumber + " / " + secondNumber + " = " + result);
        }
    }
}