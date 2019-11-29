int idTracker = 0;
var task1 = new Task(idTracker+=1, "task1");
var task2 = new Task(idTracker+=1, "task2");
Console.WriteLine(task1.Id);
Console.WriteLine(task2.Id);
// Console.WriteLine(task1.Text);

var todoList = new ToDo("Todo");
// Console.WriteLine(todoList.Name);
todoList.Tasks.Add(task1);
todoList.Tasks[0].isFinished = false;
Console.WriteLine($"task is finished? {todoList.Tasks[0].isFinished}");

var archive = new Archive("Archive");
archive.Tasks.Add(task2);
archive.Tasks[0].isFinished = true;
Console.WriteLine($"task is finished? {archive.Tasks[0].isFinished}");
            