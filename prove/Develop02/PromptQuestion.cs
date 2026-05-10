using System.Collections.Generic;

public class PromptQuestion
{
    // List to hold the 5 required prompts
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomQuestion()
    {
        // will randomly pick an index based on the number of items in the list
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}