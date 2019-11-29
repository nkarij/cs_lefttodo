using System;
using System.Collections.Generic;

namespace LeftToDo
{
    public class Submenu : Menu
    {
        public Submenu() {}

        public void RunSubMenu(){
            Console.WriteLine("=================== MENU =====================");
            Console.WriteLine("[1] set status: pending!");
            Console.WriteLine("[2] set status: finished!");
        }
    }
    
    // husk at submenu arver metode getMenuInput fra Menu
    
}


