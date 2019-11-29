using System;
using System.Collections.Generic;

namespace LeftToDo
{
    // subclass ToDo List
    // "chained" generic type
    class Archive : BaseList<Task> {

        // chained constructor
        public Archive(string name)
        {
            Name = name;
        }

        // implementing abstract property
        public override string Name { get; set; }

        public override List<Task> Tasks { get; set; } 

        // methods:
        public override void printList(){
            Console.WriteLine("Archived Tasks:");
            foreach (Task item in Tasks)
            {   
                if(item.isFinished == true) {
                    Console.WriteLine($"[{item.Id}] {item.Text} - Done. Press to change status!");
                }
            }
        }
    }
}