using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {   
        int favouriteNum;
        int squareNum = 0;
        int birthYear = 0;

        DisplayWelcome();
        string name = PromptUserName();
        try
        {
            favouriteNum = PromptUserNumber();
            PromtUserBirthYear(out birthYear);
            squareNum = SquareNumber(favouriteNum);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Wrong input, enter a number");
            Console.WriteLine("Exception message: " + ex.Message);
        }
        
        DisplayResult(name, squareNum, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromtUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return Convert.ToInt32(Math.Sqrt(number));
    }

    static void DisplayResult(string name, int squaredNum, int birthYear)
    {
        DateTime localDate = DateTime.Now;
        int age = localDate.Year - birthYear;
        Console.WriteLine(name + ", the square of your number is " + squaredNum );
        Console.WriteLine(name + ", you will turn " + age + " this year." );
    }
}