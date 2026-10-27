
class MathAssignmnet : Assigment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignmnet(string section, string problems, string name, string topic) : base(name,topic)
    {
        _textBookSection = section;
        _problems = problems;
    }

    public void GetHomeworkList()
    {
        Console.WriteLine(_textBookSection + " " + _problems);
    }
}