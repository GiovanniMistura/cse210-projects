using System;
using System.Dynamic;
using System.Text;

class Journal()
{
    private List<Entry> _entries = new List<Entry>();

    // Add an Entry to the array _entries
    public void AddEntry(Entry e)
    {
       _entries.Add(e);
    }

    // Displays the array _entries
    public void DisplayEntries()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    // Save the array _entries in a file that is created if not exists.
    public void Save(string fileName)
    {
        // If the file do not exits it is created
        if (!File.Exists(fileName))
        {
            FileStream file = File.Create(fileName);
            file.Close();
        } 

        try
        {
            // Each line of the file contain an entry
            // and the attribute are separated by ~
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (Entry e in _entries)
                {
                    sw.WriteLine(e.getDate()  + "~" + e.getPrompt() + "~" + e.getInput());
                }
                 
            }   

                
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be written");
        }
        

    }

    // Load a specific file in the array _entries, overwriting it.
    public void Load(string fileName)
    {
        try
        {
            // Open the text file using a stream reader.
            using (StreamReader reader = new(fileName))
            {
                String line;
                _entries.Clear();
                // read each line until line is null
                while ((line = reader.ReadLine()) != null)
                {
                    // gets the attributes, each separated by ~
                   string[] entries = line.Split("~");
                   Entry e = new Entry();
                   e.setDate(entries[0]);
                   e.setPrompt(entries[1]);
                   e.setInput(entries[2]);
                   _entries.Add(e);

                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
            Environment.Exit(1);
        }
    }

}