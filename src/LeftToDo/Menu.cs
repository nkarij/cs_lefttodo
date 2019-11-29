using System;
using System.Collections.Generic;

namespace LeftToDo
{
    public class Menu : BaseList<Task>
    {
        public Menu(){}

        public void runMainMenu(){

            Console.WriteLine("=================== MENU =====================");
            Console.WriteLine("[1] List all pending tasks");
            Console.WriteLine("[2] Add new task ");
            Console.WriteLine("[3] List all archived tasks");
            Console.WriteLine("[4] Archive all finished tasks");
             Console.WriteLine("[5] Exit Program");
        }

        public int getMenuInput(){
            // Console.WriteLine(Tasks.Count+1);
            var input = Console.ReadLine();
            var integer = Convert.ToInt32(input);
            if (!Double.IsNaN(integer)){
                return integer;
            } else {
                throw new ArgumentException("Input is different than expected");
            }
        }
    }
}


// let input = startMenu();
// function startMenu(){
//     return input
// }