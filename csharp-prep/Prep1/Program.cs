using System;

class Program
{
    static void Main(string[] args)
    {
        //take the name
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();

        //take the last name
        Console.Write("What is your first last name? ");
        string lastName = Console.ReadLine();

        //print the name and last name with line spacing
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {name} {lastName}");


    }
}