using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp1.UserActivity
{
    public class CheckItem : ToDoAction
    {
        public static void DisplayAllItems()
        {
            if (toDoList.Count > 0)
            {
                Console.WriteLine("All Tasks:");
                foreach(var item in toDoList)
                {
                    Console.WriteLine($"ID: {item.Id} - Description: {item.Description} - Task: {item.Task} - Due Date: {item.DueDate}");
                }
            }
            else 
             Console.WriteLine("No Tasks in your ToDo List");
            
        }
    }
}
