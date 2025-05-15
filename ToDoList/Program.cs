class ToDoList
{
    public static void Main()
    {
        bool isActive = true;
        List<string> taskList = new List<string>();
        string delInput;



        while (isActive)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Add a task (type 'add')");
            Console.WriteLine("2. Delete a task (type 'delete')");
            Console.WriteLine("3. Display all tasks (type 'show')");
            Console.WriteLine("4. Exit (type 'exit')");
            Console.WriteLine();

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
                        Console.WriteLine("Press Enter to Proceed Further");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                    else
                    {
                        taskList.Add(userTask);
                        Console.WriteLine("Task Added Successfully");
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to Proceed Further");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                //Completed - V1 (in V2 I'm planning to store in local device)
                case "delete":
                    Console.WriteLine();
                    Console.WriteLine("Deleting a Task");
                    Console.WriteLine();
                    Console.WriteLine("What task you want to remove (type sentence or keyword that represents your desired task");

                    delInput = Console.ReadLine().Trim();
                    if (taskList.Any(task => task.Contains(delInput)))
                    {
                        taskList.RemoveAll(task => task.Contains(delInput));
                        Console.WriteLine("Removed Successfully");
                    }

                    else
                    {
                        Console.WriteLine("Nothing found");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press Enter to Proceed Further");
                    Console.ReadKey();
                    Console.Clear();
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
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to Proceed Further");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "exit":
                    Console.WriteLine();
                    Console.WriteLine("Exiting the program");
                    isActive = false;
                    break;

                default:
                    Console.WriteLine("Write given things only");
                    Console.WriteLine();
                    break;
            }
        }
    }
}



// In V2
// I'm Planning Modularize from smaller things to larger functions (specifically in this order)
// Bring a way to store this in Internal Storage

// In V3
// Create MAUI or Windows Widget which can be hang around/above other screens.