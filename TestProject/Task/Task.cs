using TaskManagementSystem.Enums;

namespace TestProject.Task;

public class TaskTest
{
    [Test]
    public void TitleTest()
    {
        TaskManagementSystem.Classes.Task task = new();
        string testTitle = "jkdgfbhgfwegyugq83u4fJNBHIGY*&R#Y(HR#*(IJOI))";
        task.Title = testTitle;
        Assert.AreEqual(testTitle, task.Title);
    }
    [Test]
    public void DescriptionTest()
    {
        TaskManagementSystem.Classes.Task task = new();
        string testDescription = "jkdgfbhgfwegyugq83u4fJNBHIGY*&R#Y(HR#*(IJOI))";
        task.Description = testDescription;
        Assert.AreEqual(testDescription, task.Description);
    }
    [Test]
    public void StatusTest()
    {
        TaskManagementSystem.Classes.Worker worker = new();
        TaskManagementSystem.Classes.Task task = new();
        worker.AddTask(task);
        worker.ChangeStatusTask(task, Status.Done);
        Assert.AreEqual(Status.Done, task.StatusTask);
    }
}