using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp1.UserActivity
{
    public abstract class ToDoAction
    {

        public static List<ToDoItem> toDoList = new();
        public static int CurrentId = 0;
    }
}
