
class Menu
{
    private BreathingActivity _breathingActivity;
    private ListingActivity _listingActivity;
    private ReflectionActivity _reflectionActivity;

    public Menu() {}
    public Menu(BreathingActivity breathingActivity, ListingActivity listingActivity, ReflectionActivity reflectionActivity)
    {
        _breathingActivity = breathingActivity;
        _listingActivity = listingActivity;
        _reflectionActivity = reflectionActivity;
    }

    public void StartMenu()
    {
        string choice = "";
        while (!choice.Equals("4"))
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: "); 
            choice = Console.ReadLine();

            if (choice.Equals("1"))
            {
                _breathingActivity.Run();
            }
            else if (choice.Equals("2"))
            {
                _reflectionActivity.Run();
            }
            else if (choice.Equals("3"))
            {
                _listingActivity.Run();
            }
        }

        
    }
}