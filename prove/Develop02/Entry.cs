using System;

class Entry()
{
    private string _date = "";
    private string _prompt = "";
    private string _input = "";

    // Display the Entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_input}\n");
    }

    // getters and setters
    public string getDate()
    {
        return _date;
    }

    public void setDate(string date)
    {
       _date = date;
    }

    public string getPrompt()
    {
        return _prompt;
    }

    public void setPrompt(string prompt)
    {
        _prompt = prompt;
    }

     public string getInput()
    {
        return _input;
    }

    public void setInput(string input)
    {
        _input = input;
    }
}