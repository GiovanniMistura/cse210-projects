using System;
class Menu()
{
    public Journal _journal = new Journal();
    public string _fileName = "";

    // Array for the random prompts.
    string[] _prompts = ["What is your favourite color?","What is your favourite food?","What is your favourite sport?",
                            "What is your favourite book?","What is your favourite movie?"];

    // Displays the menu recorsively and receives the choice of the user
    // on that call the corrispective function.
    public void DisplayAndGetMenuChoices()
    {
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit"); 

        try
        {
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
        } 
        catch (FormatException e)
        {
            Console.WriteLine("Wrong input, try 1 to 5");
        }

            switch(choice)
            {
                case 1:
                {
                    WriteChoice();
                } break;
                case 2:
                {
                    DisplayChoice();
                } break;
                case 3:
                {
                    LoadChoice();  
                } break;
                case 4:
                {
                    SaveChoice();    
                } break;
                case 5:
                {
                    QuitChoice(); 
                } break;
            }
        }
    }

    // Create a Entry instance based on the user input.
    public void WriteChoice()
    {
        Random rnd = new Random();
        Entry e = new Entry();
        int rnd_num = rnd.Next(0,_prompts.Length-1);
        Console.WriteLine(_prompts[rnd_num]);
        Console.Write("> ");
        e._input = Console.ReadLine();
        e._prompt = _prompts[rnd_num];
        e._date = DateTime.Now.ToString("dd/MM/yyyy");
        _journal.AddEntry(e);

    }

    // Display all the Entries.
    public void DisplayChoice()
    {
        _journal.DisplayEntries();
    }

    // Load a specific file (in the project folder)
    // in a Journal instance, overwriting the old one if present.
    public void LoadChoice()
    {
        Console.Write("Insert the name of the file: ");
        _fileName = Console.ReadLine();
        _journal.Load(_fileName);
    }

    // Save the current Journal in a file, if it does not exist
    // it is also created, if it exist overwrites the old content with the new one.
    public void SaveChoice()
    {
        Console.Write("Insert the name of the file: ");
        _fileName = Console.ReadLine();
        _journal.Save(_fileName);
    }

    // Exits the program
    public void QuitChoice()
    {
        Environment.Exit(0);
    }
}