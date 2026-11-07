
class BreathingActivity : Activity
{
    
    public BreathingActivity() {}

    public BreathingActivity(string name, string desc) : base(name,desc)
    {
        
    }

    public void Breath(int duration)
    {
        // to create random number for the activity
        Random rnd = new Random();
        // calculate end time of the activity
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        DateTime nowTime = DateTime.Now;
        while (DateTime.Compare(endTime, nowTime) > 0)
        {
            int randomNum = rnd.Next(3,6);
            Console.Write("\n\nBreathe in... ");
            CountDown(randomNum);
            Console.Write("\nBreathe out... ");
            CountDown(randomNum);
            nowTime = DateTime.Now;  
        }


    }

    public void Run()
    {
        ShowPrologue();
        Breath(_duration);
        ShowEpilogue();
    }
}