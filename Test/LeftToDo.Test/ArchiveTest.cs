using System;
using Xunit;

namespace LeftToDo.Test
{
    public class ArchiveTest
    {
        [Fact]
        public void testArchivePrintList(){
            // arrange:
            var testlist = new Archive("Name");
            var testtask = new Task(0, "One");
            var testtask1 = new Task(1, "Two");
            testtask.isFinished = true;
            testtask1.isFinished = true;
            int numberOfTrues = 0;

            // act
            testlist.Tasks.Add(testtask);
            testlist.Tasks.Add(testtask1);
            foreach (var task in testlist.Tasks)
            {
                if(task.isFinished == true){
                    numberOfTrues+=1;
                }
            }
            // assert
            Assert.Equal(numberOfTrues, 2);
        }
    }
}
