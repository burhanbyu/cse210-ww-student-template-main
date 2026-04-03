using System;

class Program
{
    static void Main()
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice: ");

            string input = Console.ReadLine();
            int.TryParse(input, out choice);

            if (choice == 1)
            {
                Console.WriteLine("Starting Breathing Activity...");
                new BreathingActivity().Run();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Starting Reflection Activity...");
                new ReflectionActivity().Run();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Starting Listing Activity...");
                new ListingActivity().Run();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}