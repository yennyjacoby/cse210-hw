using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.VisualBasic;

public class Journal

{
    // Attributes
    // This will store ALL journal entries (each entry is a string or Entry object)
    public List<Entry> _entries = new List<Entry>();

    // This will store the filename when saving/loading
    public string _fileName;

    // METHODS
    // Saving all entries
    public void SaveFile()
    {
        Console.Write("Write the name of the file: ");
        string fileName = Console.ReadLine();

        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }

        try

        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry._selectedPrompt);
                    writer.WriteLine(entry._userEntry);
                    writer.WriteLine(DateTime.Now);
                    writer.WriteLine("************************");   // separator
                }
            }

            Console.WriteLine($"Your Journal has been saved in '{fileName}'");    
        }
        catch (Exception)
        {
            Console.WriteLine("The file could not be saved");
        }

    }

    public void LoadFile()
    {
        Console.Write("Type the name of the file you want to load: ");
        string fileName = Console.ReadLine();

        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }

        if (!File.Exists(fileName))
        {
            Console.WriteLine($"The file {fileName} does not exist");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    Entry newEntry = new Entry();

                    newEntry._selectedPrompt = reader.ReadLine();
                    newEntry._userEntry = reader.ReadLine();
                    string dateLine = reader.ReadLine();
                    string separator = reader.ReadLine();

                    _entries.Add(newEntry);
                }
            }
            Console.WriteLine("It was uploaded succesfully!");
        }
        catch (Exception)
        {
            Console.WriteLine("The file could not be loaded");
        }
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine ("*************************");
        }
    }

    public void StoreEntry()
    {
        Entry newEntry = new Entry();

        //RandomPrompt
        string prompt= newEntry.RandomPrompt();
        Console.WriteLine(prompt);

        Console.Write("Your answer: ");
        newEntry._userEntry = Console.ReadLine();

        _entries.Add(newEntry);
    }
}