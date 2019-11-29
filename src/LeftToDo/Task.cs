using System;
using System.Collections.Generic;

namespace LeftToDo
{
    public class Task
    {
        public Task(int id, string text)
        {
            this.Id = id;
            this.Text = text;
            isFinished = false;
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public bool isFinished { get; set; }

        public void SetStatus(int input, Task task){
            if(!Single.IsNaN(input)){
                // Console.WriteLine("Er ikke et single nr");
                    switch (input)
                {
                    case 1:
                    task.isFinished = false;
                    break;
                    case 2:
                    task.isFinished = true;
                    break;
                    default: 
                    task.isFinished = false;
                    break;
                }
            }
            
        }

    }
}