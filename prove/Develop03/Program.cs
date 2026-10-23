using System;
using System.Reflection.Metadata;
using System.Collections.Generic;

// to exceed the rquirements my program after all the words are hidden
// asks if the user want to try now to insert back all the words
class Program
{
    static void Main(string[] args)
    {
        // initialazing the instances
        //Reference reference = new Reference("2 Nephi",2,24,25);
         Reference reference = new Reference("Philippians",4,13);
        List<Word> list = new List<Word>();
        Scripture scripture = new Scripture(reference,list);
        string[] scriptureString = ["I","can","do","all","things","through","Christ","who","strengthens","me."];
        // string[] scriptureString = [
        //     "But", "behold,", "all", "things", "have", "been", "done", "in", "the",
        //     "wisdom", "of", "him", "who", "knoweth", "all", "things.", "Adam",
        //     "fell", "that", "men", "might", "be;", "and", "men", "are,", "that", "they",
        //     "might", "have", "joy."
        // ];
        foreach (String w in scriptureString)
        {
            scripture.AddWord(new Word(w));
        }

        // service variables
        // initialized counter to -1 to display the scripture without blank spaces at the
        // begining of the program
        int counter = -1; 
        string input = "";
        // to hide randomly the words i create an array with all the positions in
        // a random order
        Random rng = new Random();
        int[] array = Enumerable.Range(0, scriptureString.Length).ToArray();
        rng.Shuffle(array);

        // start of the main part program
        while (input != "quit" && counter < scriptureString.Length)
        {          
            Console.Clear();
            // the first loop we do not hide any words as is the start of the 
            // memorize program
            if (counter >= 0)
            {
                scripture.HideWord(array[counter]);   
            }  
            scripture.Display();
            Console.Write("\n\nPress Enter to continue or type \'quit\' to finish: ");
            input = Console.ReadLine();
            counter++;
        }

        // additional part of the program
        // writing all the word back
        Console.Clear();
        scripture.Display();
        Console.Write("\n\nDo you want to try to write back all the words? [y/n] ");
        input = Console.ReadLine();
        // if 'n' exit from the program
        if (input != "y")
        {
            Environment.Exit(0);
        }

        // if not continue
        counter = 0;
        while (input != "quit" && counter < scriptureString.Length)
        {          
            Console.Clear();
            scripture.Display();
            Console.Write("\n\nEnter a word or type \'quit\' to end: ");
            input = Console.ReadLine();
            // do not increment until the word is right
            if (scripture.isWordPresent(input))
            {
                int index = scripture.getWordIndex(input);
                scripture.RevealWord(index);  
                counter++; 
            }  
        }
        // final messagge if succesful
        if (input != "quit")
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("You got it!");
        }
    }
}