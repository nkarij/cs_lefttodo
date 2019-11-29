using System;
using System.Collections.Generic;

namespace LeftToDo
{
    class Program : BaseList<Task>
    {
        static void Main(string[] args)
        {
            // initialising/declaring variables
            int idTracker = 0;
            var MainMenu = new Menu();
            var SubMenu = new Submenu();
            var ToDoList = new ToDo("ToDo List");
            var ArchiveList = new Archive("Archive");
            int input;

            while(true) {

                MainMenu.runMainMenu();
                input = MainMenu.getMenuInput();

                switch (input)
                {
                    case 1:
                        Console.Clear();
                        ToDoList.printList();
                        var taskIndex = MainMenu.getMenuInput();
                        Console.WriteLine(taskIndex);
                        // if(Console.KeyAvailable){
                        // var key = Console.ReadKey().Key;
                        // Console.WriteLine($"key: {key}");
                        var task = ToDoList.findTask(taskIndex);
                        SubMenu.RunSubMenu();
                        var subChoice = SubMenu.getMenuInput();
                        task.SetStatus(subChoice, task);
                        if(subChoice == 1) {
                            ToDoList.printList();
                        } else if(subChoice == 2) {
                            ArchiveList.printAll();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("What is the task:");
                        string taskText = Console.ReadLine();
                        ToDoList.createNewTask(idTracker+=1, taskText);
                        // ToDoList.printList();
                        break;
                    case 3:
                        Console.Clear();
                        ArchiveList.printList();
                        break;
                    case 4:
                        Console.Clear();
                        // should this be the archive list?
                        ToDoList.printList();
                        break;
                    case 5:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
