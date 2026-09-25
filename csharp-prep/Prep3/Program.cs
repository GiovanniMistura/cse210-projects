using System;

class Program
{
    static void Main(string[] args)
    {

        // variables
        Random rnd = new Random();
        int answered_num = -1;
        int number_guesses = 0;
        string continue_game = "yes";

        while (continue_game == "yes")
        {
            // Generate a random number
            int random_num = rnd.Next(1,100);

            // Start the guessing game
            Console.WriteLine("Guess a namber between 0 and 100!");

            // Core of the game
            while (answered_num != random_num)
            {
                // User guess
                Console.Write("Insert your guess: ");
                answered_num = int.Parse(Console.ReadLine());

                // Checking the guess
                if (answered_num < random_num)
                {
                    Console.WriteLine("Higer");
                }
                else if (answered_num > random_num)
                {
                    Console.WriteLine("Lower");
                }
                number_guesses++;
            }

            Console.WriteLine("You guess it!");
            Console.WriteLine("It took you " + number_guesses + " guesses!");

            Console.Write("Do you want to play again? ");
            continue_game = Console.ReadLine();
        }
    }
}