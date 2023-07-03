using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp1
{
    public class ToDoAction
    {
        //ToDoItem item = new();
        public List<ToDoItem> toDoList = new();

        public void AddNewItem(string task, string description, DateTime duedate)
        {
            Console.WriteLine("Enter Task Name: ");
            task = Console.ReadLine();

            Console.WriteLine("Eneter task description: ");
            description = Console.ReadLine();

            Console.WriteLine("Enter due date (yyyy-mm-dd): ");
            duedate = DateTime.Parse(Console.ReadLine());



            
        }

    }
}
