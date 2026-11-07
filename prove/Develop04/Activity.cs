
using System.Runtime.CompilerServices;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity() {}
    
    public Activity(string name, string desc)
    {
        _name = name;
        _description = desc;
    }

    public void ShowPrologue()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the " + _name);
        Console.WriteLine("\n" + _description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        try
        {
            _duration = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Wrong Input!");
            Environment.Exit(1);
        }
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(1);
        
    }

    public void ShowEpilogue()
    {
        Console.WriteLine("\n\nWell Done!!");
        Spinner(2);
        Console.WriteLine("\nYou have completed another " + _duration + " seconds of the " + _name);
        Spinner(2);
    }

    public void Spinner(int spins)
    {
        Console.CursorVisible = false;
        int totalLength = 5;

        // Loop from 0 to 5 to print the different spinners
        for (int i = 0; i <= totalLength; i++)
        {
            string hashes = new string('#', i);
            string dashes = new string('-', totalLength - i);
            
            Console.Write($"\r{hashes}{dashes}");
            Thread.Sleep(500); 
        }

        Console.Write("\r     \r");
        Console.CursorVisible = true;
        
    }

    public void CountDown(int duration)
    {
        for (int i = 0; i<duration; i++)
        {
            Console.Write(duration-i);
            Thread.Sleep(1000);
            Console.Write("\b \b");  
        }
    }
}