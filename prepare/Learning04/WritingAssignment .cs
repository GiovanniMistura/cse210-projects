
class WritingAssignment : Assigment
{
    private string _title;
     public WritingAssignment(string title,string name, string topic) : base(name,topic)
    {
       _title = title; 
    }

    public void GetWritingInformation()
    {
        Console.WriteLine(_title + " by " + _studentName);
    }
}