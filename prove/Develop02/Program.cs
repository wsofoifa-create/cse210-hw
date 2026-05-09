

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptQuestion promptQuestion = new PromptQuestion();
        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Please select a choice:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4 Save\n5. Quit");
            Console.Write("What would you like to do?");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptQuestion.GetRandomQuestion();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry { _date = date, _promptText = prompt, _entryText = response }; 
                theJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
                {
                    theJournal.DisplayAll();
                }
        }
    }
   
}