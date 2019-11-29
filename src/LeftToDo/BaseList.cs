using System;
using System.Collections.Generic;

namespace LeftToDo
{
    public class BaseList<T>
    {
        public BaseList()
        {
            // Name = name;
            this.Tasks = new List<T>();
        }

        public virtual string Name { get; set; }

        public virtual List<T> Tasks { get; set; } 
    
        // method will be overridden in subclasses
        public virtual void printAll(){}

        public virtual void printList(){}
        // public abstract List<Task> tasks = new List<Task>();
                
    }
}