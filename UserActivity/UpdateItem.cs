using ToDoApp1;
using ToDoApp1.UserActivity;

public  class UpdateItem: ToDoAction
{

    public static void AddNewItem()
    {
        Console.WriteLine("Let's create a new task.....\n");

        Console.WriteLine("Enter Task Name: ");
        string? task = Console.ReadLine();

        Console.WriteLine("Eneter task description: ");
        string? description = Console.ReadLine();

        Console.WriteLine("Enter due date (yyyy-mm-dd): ");
        DateTime duedate = DateTime.Parse(Console.ReadLine());



        ToDoItem newItem = new(CurrentId, description, task, duedate);
        toDoList.Add(newItem);
        CurrentId++;

        if (CurrentId == toDoList.Count)
            Console.WriteLine("New task added successfully");
        else
            Console.WriteLine("Task not added!");

    }
}