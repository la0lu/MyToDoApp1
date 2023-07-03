using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp1.UserActivity;

namespace ToDoApp1
{
    public static class Menu
    {
        private static string[] options;
        
         static Menu()
        {
            options = new string[]
            {
                "Add new task",
                "Edit task",
                "Delete task",
                "Search task",
                "Display all tasks",
                "Exit App"
            };
        } 

        public static void DisplayToDoMenu() 
        {
            Console.WriteLine("Welcome to your TO-DO App");
            Console.WriteLine("What do you want to do today?\n");
            
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{1 + i}. {options[i]}");
            }
            Console.WriteLine("\nselect an option");
            int option = int.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:
                    Console.Clear();
                    UpdateItem.AddNewItem();
                    break;

                case 5:
                    Console.Clear();
                    CheckItem.DisplayAllItems();
                    break;

                default: 
                    Console.WriteLine("please input a valid option");
                    Console.Clear();
                    DisplayToDoMenu();
                    break;

            }
        }

        
    }
}
