
using System.Runtime.CompilerServices;

class Scripture
{
    
    private List<Word> _wordList = new List<Word>();
    private Reference _reference;

    // utility array
    private char[] punctuation = new char[] {':', ';', ',', '.', ' '};

    // contructors
    public Scripture() {}
    public Scripture(Reference reference, List<Word> list)
    {
        _wordList = list;
        _reference = reference;
    }

    // methods
    public void AddWord(Word word)
    {
        _wordList.Add(word);
    }

    public void setReference(Reference reference)
    {
        _reference = reference;
    }

    public void Display()
    {
        Console.Write(_reference.getReference() + " ");
        foreach (Word w in _wordList)
        {
            Console.Write(w.getText() + " ");
        }
    }

    public void HideWord(int position)
    {
        _wordList[position].Hide();
    }

    public void RevealWord(int position)
    {
        _wordList[position].Reveal();
    }

    // in both isWordPresent and getWordIndex
    // when a text is compared the case and puctuation are 
    // not taken into account
    public bool isWordPresent(string text)
    {
       return _wordList.Any(item => item.getTextNoHidden().Trim(punctuation).ToLower() == text.ToLower());
    }

    public int getWordIndex(string text)
    {
        for (int i = 0; i<_wordList.Count; i++)
        {
            if (_wordList[i].getTextNoHidden().Trim(punctuation).ToLower() == text.ToLower())
            {
                return i;
            }
        }
        return -1;
    }
}