
class Word
{
    
    private string  _text;
    private Boolean _isHidden;

    // constructors
    public Word() {}

    public Word(string text, Boolean hidden = false)
    {
        _text = text;
        _isHidden = hidden;
    }

    // methods
    public void Hide()
    {
        _isHidden = true;
    }

    public void Reveal()
    {
        _isHidden = false;
    }

    // it return the text or '____' if isHidden is true
    public string getText()
    {
        return _isHidden ? "____" : _text;
    }

    // returns alway the text
    public string getTextNoHidden()
    {
        return _text;
    }

    public void setText(string text)
    {
        _text = text;
    }

}