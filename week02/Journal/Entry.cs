
using System;
using System.Security.Cryptography.X509Certificates;

public class Entry

{
    // STRUCTURE
    // ============================
    // ATTRIBUTES (member variables)
    // These describe what an Entry *has*
    // ============================

    // The text the user writes for this journal entry
    public string _userEntry;
    
    // Attribute field that store data
    public List<string> _prompts= new List<string>()
    {
        "What was your favorite part of the day?",
        "Did you help someone in any way?",
        "What is something you feel you should have done different? ",
        "What are you grateful for? ",
        "What did you learn during the day?"
    };

    // This will store whichever prompt was randomly selected
    public string _selectedPrompt;

    //attribute! / fields or member variables.
    Random random = new Random();

    // ============================
    // METHODS (behaviors/actions)
    // These describe what an Entry *does*
    // ============================

    // This method selects a random prompt from the list
    public string RandomPrompt()
    {
        int index = random.Next(_prompts.Count);  //pick a random number
        _selectedPrompt = _prompts[index];  //Store the chosen prompt
        return _selectedPrompt;
    }

    // This method displays the full entry:
    // - the prompt
    // - the user's response
    // - the date
    public void Display()
    {
        Console.WriteLine ($"{_selectedPrompt} {_userEntry}");
        Console.WriteLine (DateTime.Now);  
    }
}

