
namespace TestProject.Worker;

public class WorkerTaskTest
{
    [Test]
    public void TaskTest1()
    {
        TaskManagementSystem.Classes.Worker worker = new();
        TaskManagementSystem.Classes.Task task = new();
        worker.AddTask(task);
        Assert.That(worker.Tasks.First(), Is.EqualTo(task));
    }
    [Test]
    public void TaskTest2()
    {
        TaskManagementSystem.Classes.Worker worker = new();
        TaskManagementSystem.Classes.Task task = new();
        TaskManagementSystem.Classes.Task task2 = new();
        worker.AddTask(task);
        worker.AddTask(task2);
        _ = worker.DeleteTaskAt(0);
        Assert.That(worker.Tasks.First(), Is.EqualTo(task2));
    }
}