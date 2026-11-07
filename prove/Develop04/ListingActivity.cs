
class ListingActivity : Activity
{
    private string[] _prompts = ["Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?",
                                    "When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"];
    
    public ListingActivity() {}

    public ListingActivity(string name, string desc) : base(name, desc)
    {
        
    }

    public void Run()
    {
        // random object
        Random rnd = new Random();

        // variable to count the responses
        int counter = 0;

        // array with all the answers
        List<string> inputs = new List<string>();

        // start 
        ShowPrologue();
        Console.WriteLine("\nList as many responses as you can to the following prompt: ");
        Console.WriteLine("\n--- " + _prompts[rnd.Next(0,_prompts.Length)] + " ---");
        Console.WriteLine("\nYou may begin in: ");
        CountDown(5);

        // calculate end time of the activity
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        DateTime nowTime = DateTime.Now;
        while (DateTime.Compare(endTime, nowTime) > 0)
        {
            Console.Write("> ");
            inputs.Add(Console.ReadLine());
            counter++; 
            nowTime = DateTime.Now;  
        }
        Console.Clear();
        Console.WriteLine("You listed " + counter + " items!");
        Console.WriteLine("\nThe itmes are: ");
        foreach(string input in inputs)
        {
            Console.WriteLine("- " + input);
        }
        ShowEpilogue(); 

    }
}