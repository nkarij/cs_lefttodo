using System;
using Xunit;

namespace LeftToDo.Test
{
    public class Menu
    {
        [Fact]
        public void testInputType()
        {
            
        // arrange
        var todo = new ToDo("TestToDo");
        // string a = "0";
        // string b = "15";
        // string c = "y";
        // string d = "";
        string e = "1";
        
        // act
        // var fail1 = getMenuInput(a);
        // var fail2 = getMenuInput(b);
        // var fail3 = getMenuInput(c);
        // var fail4 = getMenuInput(d);
        var succes = getMenuInput(e);

        // assert
        // Assert.InRange(fail1, 1, 5);
        // Assert.InRange(fail2, 1, 5);
        // Assert.InRange(fail3, 1, 5);
        // Assert.InRange(fail4, 1, 5);
        Assert.InRange(succes, 1, 5);

        }

        

        // this function is replacing the original, that asks for a readline();
        public int getMenuInput(string input){
            // Console.WriteLine(Tasks.Count+1);
            var integer = Convert.ToInt32(input);
            if (!Double.IsNaN(integer)){
                return integer;
            } else {
                throw new ArgumentException("Input is different than expected");
            }
        }


    }
}
