using System;

// A code template for the category of things known as Journal Prompts
public class JournalPrompt
{
    // The C# convention is to start member variables with an underscore _

    public static string[] _prompt = {
        "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "List the places I have been to today.",
            "What was the best idea you had today?",
            "List the 3 things you are grateful for today and why.",
            "What was the most outrageous thing you did today?",
            "What was the best meal of the day today and what was it?",
            "Who made you feel good today?",
            "What did you learn today?",
            "What is the funniest thing that happened today?",
            "If you could become an expert in any subject or activity, what would it be?",
            "What would you buy today if money were no object?",
            "How did you procrastinate on important tasks today?",
            "What scripture just popped into your head right now?",
            "What is something that made you laugh today?",
            "Who made your day better today?",
            "What is one thing you want to remember from today?",
            "Would you change any of the decisions you made today?",
            "What frightened you today?",
            "Who do you wish you had talked to today? What would you say?",
            "If you’d had another hour during the day, how would you have spent it?",
            "Reflect on how your body feels. Sore, Stressed, Tired, Energized",
            "Did you read a book today? If so what?",
            "Did you watch a movie today? If so what?",
            "Did you watch a TV show today? If so what?"
    };
    public List<string> _journalPrompt = new List<string>(_prompt);

    public JournalPrompt()
    {

    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        
        return journalPrompt;
    }
}