using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();
            manager.DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            int.TryParse(Console.ReadLine(), out choice);

            if (choice == 1)
            {
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                int type = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == 1)
                    manager.CreateGoal(new SimpleGoal(name, desc, points));
                else if (type == 2)
                    manager.CreateGoal(new EternalGoal(name, desc, points));
                else if (type == 3)
                {
                    Console.Write("Target: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());

                    manager.CreateGoal(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }
            else if (choice == 2)
            {
                manager.ListGoalNames();
                Console.ReadLine();
            }
            else if (choice == 3)
            {
                manager.ListGoalNames();
                Console.Write("Select goal #: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                manager.RecordEvent(index);
                Console.ReadLine();
            }
            else if (choice == 4)
            {
                Console.Write("Filename: ");
                manager.SaveGoals(Console.ReadLine());
                Console.ReadLine();
            }
            else if (choice == 5)
            {
                Console.Write("Filename: ");
                manager.LoadGoals(Console.ReadLine());
                Console.ReadLine();
            }
        }

        Console.WriteLine("Goodbye!");
    }
}