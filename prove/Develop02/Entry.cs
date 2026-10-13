using System;

class Entry()
{
    public string _date = "";
    public string _prompt = "";
    public string _input = "";

    // Display the Entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_input}\n");
    }
}