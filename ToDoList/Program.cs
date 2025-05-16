class ToDoList
{
    public static void Main()
    {
        bool isActive = true;
        List<string> taskList = new List<string>();
        string delInput;

        if (File.Exists("tasks.txt"))
        {
            taskList = File.ReadAllLines("tasks.txt").ToList();
        }

        while (isActive)
        {
            MenuItems();

            string userAction = Console.ReadLine().ToLower();

            switch (userAction)
            {
                //Completed - V1 (in V2 I'm planning to store in local device)
                case "add":
                    Console.WriteLine();
                    Console.WriteLine("Write down your task here");
                    string userTask = Console.ReadLine();

                    if (userTask == "")
                    {
                        Console.WriteLine("Enter a proper value");
                        SpaceandPause();
                        break;
                    }

                    else
                    {
                        taskList.Add(userTask);
                        File.WriteAllLines("tasks.txt", taskList);
                        Console.WriteLine("Task Added Successfully");
                        SpaceandPause();
                        break;
                    }

                //Completed - V1 (in V2 I'm planning to store in local device)
                case "delete":
                    Console.WriteLine();
                    Console.WriteLine("Deleting a Task");
                    Console.WriteLine();

                    //Currently deletion is happening using keyword
                    Console.WriteLine("What task you want to remove (type sentence or keyword that represents your desired task");
                    delInput = Console.ReadLine().Trim();
                    if (taskList.Any(task => task.Contains(delInput)))
                    {
                        taskList.RemoveAll(task => task.Contains(delInput));
                        File.WriteAllLines("tasks.txt", taskList);
                        Console.WriteLine("Removed Successfully");
                    }

                    else
                    {
                        Console.WriteLine("Nothing found");
                    }

                    SpaceandPause();
                    break;

                //Completed - V1 (in V2 I'm planning to store in local device)
                case "show":
                    Console.WriteLine();
                    Console.WriteLine("Printing all tasks");
                    foreach (string task in taskList)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"--> {task}");
                    }
                    SpaceandPause();
                    break;

                case "exit":
                    Console.WriteLine();
                    Console.WriteLine("Exiting the program");
                    isActive = false;
                    break;

                default:
                    Console.WriteLine("Write given things only");
                    SpaceandPause();
                    break;
            }
        }
    }
    
    public static void MenuItems()
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1. Add a task (type 'add')");
        Console.WriteLine("2. Delete a task (type 'delete')");
        Console.WriteLine("3. Display all tasks (type 'show')");
        Console.WriteLine("4. Exit (type 'exit')");
        Console.WriteLine();
        return;
    }
    public static void SpaceandPause()
    {
        Console.WriteLine();
        Console.WriteLine("Press Enter to Proceed Further");
        Console.ReadKey();
        Console.Clear();
        return;
    }
}



// In V2
// I'm Planning Modularize from smaller things to larger functions (specifically in this order) ()
// Bring a way to store this in Internal Storage 

// In V3
// Create MAUI or Windows Widget which can be hang around/above other screens.