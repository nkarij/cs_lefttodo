using System;
using System.Collections.Generic;

namespace LeftToDo
{
    // subclass ToDo List
    // "chained" generic type
    public class ToDo : BaseList<Task> {

        // chained constructor
        public ToDo(string name)
        {
            Name = name;
        }

        // implementing abstract property
        public override string Name { get; set; }

        public override List<Task> Tasks { get; set; } 
        // methods:
        // implementing abstract method

        public override void printAll(){
        foreach (Task item in Tasks)
            {   
                if(item.isFinished == false) {
                    Console.WriteLine($"[{item.Id}] {item.Text} pending");
                } else {
                    Console.WriteLine($"[{item.Id}] {item.Text} finished");
                }
            }
        }
        
        public override void printList(){
            Console.WriteLine("Pending Tasks:");
            foreach (Task item in Tasks)
            {   
                if(item.isFinished == false) {
                    Console.WriteLine($"[{item.Id}] {item.Text} is pending. Press to change status!");
                } else {
                    throw new ArgumentException("expected a boolean");
                }
            }
        }

        public void createNewTask(int id, string text){
            var task = new Task(id, text);
            Tasks.Add(task);
        }

        public Task findTask(int index){
            var task = Tasks.Find(x => x.Id == index);
            return task;
        }

        


    }
}