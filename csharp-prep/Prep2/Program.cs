using System;

class Program
{
    static void Main(string[] args)
    {
        //get the user grade
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        //print the correct letter grade
        string letter = ""; 
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";   
        }

        //recognise if there is + or - to the letter grade
        string plusOrMinor = "";
        int rest = grade % 10;

        if (rest >= 7 && letter != "A")
        {
            plusOrMinor = "+";
        }
        else if (rest < 3 && letter != "F")
        {
            plusOrMinor = "-";
        }


        Console.WriteLine($"Your letter grade is {letter}{plusOrMinor}");

        //check and print if the user passes the class
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the exam");
        } 
        else
        {
            Console.WriteLine("You did NOT pass the exam, try again!");
        }
    }
}