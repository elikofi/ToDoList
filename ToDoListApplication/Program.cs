using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using static ToDoListApplication.storage;
//Welcome message for user.
Console.WriteLine("Welcome to my ToDo List Application.");
Console.WriteLine("____________________________________");


List<string> taskList = new List<string>();
string option = "";

while (option != "e")
{
    Console.WriteLine("\nChoose a task to perform below from the options.");
    Console.WriteLine("1 - Add a task to the list.");
    Console.WriteLine("2 - Remove task(s) from the list.");
    Console.WriteLine("3 - Display ToDo List.");
    Console.WriteLine("4 - Search for a task in the list.");
    Console.WriteLine("e - Exit ToDo List.\n");

    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("Enter the task you want to add to the list:");
            string task = Console.ReadLine();
            DateTime now = DateTime.Now;
            taskList.Add(task);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nTask successfully added to list. ({now})");
            Console.ResetColor();
            Console.WriteLine("Press enter to return to main menu.");
            break;

        case "2":
            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine(i + " - " + taskList[i]);
            }
            Console.WriteLine("\nChoose the task number you want to remove:");
            int num = Convert.ToInt32(Console.ReadLine());
            taskList.RemoveAt(num);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nTask successfully removed.\n");
            Console.ResetColor();
            Console.WriteLine("Press enter to return to main menu.");
            break;

        case "3":
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var taskItem in taskList)
            {
                Console.WriteLine(taskItem);
            }
            Console.ResetColor();
            Console.WriteLine("Press enter to return to main menu.");
            break;

        case "4":
            Console.WriteLine("Enter a phrase or word which matches the task you're looking for:");
            var searchPhrase = Console.ReadLine();
            var matchingLists = taskList.Where(x => x.Contains(searchPhrase));
            foreach (var item in matchingLists)
            {
                Console.WriteLine($"\nHere are the search results:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{item}");
                Console.ResetColor();
            }
            Console.WriteLine("Press enter to return to main menu.");
            break;

        case "e":
            Console.WriteLine("\nExiting program...");
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid option! Enter a valid option.");
            Console.ResetColor();
            Console.WriteLine("Press enter to return to main menu.");
            break;
    }
    Console.ReadLine();
}
//later add time and date 