
class ReflectionActivity : Activity
{
    private string[] _prompts = ["Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.",
                                    "Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."];
    private string[] _questions = ["Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?",
                                    "How did you feel when it was complete?","What made this time different than other times when you were not as successful?",
                                    "What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?",
                                    "What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"];
    
    public ReflectionActivity() {}

    public ReflectionActivity(string name, string desc) : base(name, desc)
    {
        
    }

    public void Run()
    {
        // create array for random prompt and question
        Random rng = new Random();
        int[] randomPrompts = Enumerable.Range(0, _prompts.Length).ToArray();
        rng.Shuffle(randomPrompts);
        int[] randomQuestions = Enumerable.Range(0, _questions.Length).ToArray();
        rng.Shuffle(randomQuestions);

        //counter to access them
        int counter = 0;

        // start
        ShowPrologue();
        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine("\n--- " + _prompts[randomPrompts[counter]] + " ---");
        Console.Write("\nWhen you have something in mind press enter: ");
        string input = Console.ReadLine();
        Console.WriteLine("\nYou may begin in: ");
        CountDown(5);
        Console.Clear();
        
        // calculate end time of the activity
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        DateTime nowTime = DateTime.Now;
        while (DateTime.Compare(endTime, nowTime) > 0)
        {
            Console.WriteLine("> " + _questions[randomQuestions[counter]] + "  ");
            Spinner(1);
            counter++;
            nowTime = DateTime.Now;
        }
        ShowEpilogue();
    }
}