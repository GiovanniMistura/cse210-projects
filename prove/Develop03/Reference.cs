
class Reference
{
    
    private string _book;
    private int _chapter;
    private int _startVerse = -1;
    private int _endVerse = -1;

    // contructors
    public Reference() {}
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // methods
    public string getReference()
    {
        return _book + " " + _chapter + ":" + _startVerse + (_endVerse != -1 ? "-" + _endVerse : "");
    }
}