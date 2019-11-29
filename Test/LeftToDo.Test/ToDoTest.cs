using System;
using Xunit;

namespace LeftToDo.Test
{
    public class UnitTest1
    {
        [Fact]
        public void testCreateTask(){
            // arrange:
            int a = 0;
            // int b = 15;
            // string c = "y";
            string d = "";
            var testlist = new BaseList<Task>();
            var testtask = new Task(a, d);

            // act
            testlist.Tasks.Add(testtask);
            var length = testlist.Tasks.Count;
            
            Assert.Equal(length, 1);
        }


        [Fact]
        public void testFindTask(){

            // arrange:
            var testlist = new ToDo("Name");
            var testtask = new Task(0, "Name");
            var testtask1 = new Task(1, "Name");

            // act
            testlist.Tasks.Add(testtask);
            testlist.Tasks.Add(testtask1);
            var succes = testlist.findTask(0);
            var fail = testlist.findTask(0);

            // assert
            // Assert.Equal(succes, testtask);
            Assert.Equal(fail, testtask1);
        }

        // print list

        [Fact]
        public void testToDoPrintList(){
            // arrange:
            var testlist = new ToDo("Name");
            var testtask = new Task(0, "One");
            var testtask1 = new Task(1, "Two");
            int numberOfFalses = 0;

            // act
            testlist.Tasks.Add(testtask);
            testlist.Tasks.Add(testtask1);
            foreach (var task in testlist.Tasks)
            {
                if(task.isFinished == false){
                    numberOfFalses+=1;
                }
            }
            // assert
            Assert.Equal(numberOfFalses, 2);
        }

    }
}
