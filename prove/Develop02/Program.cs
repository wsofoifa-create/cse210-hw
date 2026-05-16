

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        string choice = "";

        // loop until option 5 is chosen

        while (choice != "5")
        {
            Console.WriteLine("Please select a choice:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4 Save\n5. Quit");
            Console.Write("What would you like to do?");
            choice = Console.ReadLine();

            if (choice == "1") // write
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                // create a new entry for the journal

                Entry newEntry = new Entry { _date = date, _promptText = prompt, _entryText = response }; 
                theJournal.AddEntry(newEntry);
            }
            else if (choice == "2") // display
                {
                    theJournal.DisplayAll();
                }
             else if (choice == "3") // Load
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                theJournal.LoadFromFile(fileName);
            }
            else if (choice == "4") // Save
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);
            }
        }
    }
   
}