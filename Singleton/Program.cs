using System.Threading.Tasks;
 // Create tasks to call the static method
Task task1 = Task.Run(() => Singleton.GetInstance());
Task task2 = Task.Run(() => Singleton.GetInstance());
Task task3 = Task.Run(() => Singleton.GetInstance());


// Wait for all tasks to complete
Task.WaitAll(task1, task2, task3);