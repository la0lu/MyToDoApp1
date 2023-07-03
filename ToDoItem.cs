using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp1
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }   
        
        public ToDoItem(int id, string task, string description, DateTime dueDate)
        {
            Id = id;
            Task = task;
            Description = description;
            DueDate = dueDate;
        }


    }
}
