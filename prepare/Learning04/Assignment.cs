
class Assigment
{
    protected string _studentName;
    private string _topic;

    public Assigment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public void GetSummary()
    {
        Console.WriteLine(_studentName + " - " + _topic);
    }
}