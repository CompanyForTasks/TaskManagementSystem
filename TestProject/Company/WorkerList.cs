using Moq;
using TaskManagementSystem.Interfaces;

namespace TestProject.Company;

public class WorkerListTest
{
    [Test]
    public void WorkerListTest1()
    {
        TaskManagementSystem.Classes.Company company = new();
        company.Workers = new List<IWorker>();
        TaskManagementSystem.Classes.Worker worker1 = new();
        company.HireWorker(worker1);
        Assert.AreEqual(worker1, company.Workers.ElementAt(0));
    }

    [Test]
    public void WorkerListTest2()
    {
        TaskManagementSystem.Classes.Company company = new();
        company.Workers = new List<IWorker>();
        TaskManagementSystem.Classes.Worker worker1 = new();
        TaskManagementSystem.Classes.Worker worker2 = new();
        company.HireWorker(worker1);
        company.HireWorker(worker2);
        Assert.AreEqual(worker1, company.Workers.ElementAt(0));
    }

    [Test]
    public void WorkerListTest3()
    {
        TaskManagementSystem.Classes.Company company = new();
        company.Workers = new List<IWorker>();
        TaskManagementSystem.Classes.Worker worker1 = new();
        TaskManagementSystem.Classes.Worker worker2 = new();
        company.HireWorker(worker1);
        company.HireWorker(worker2);
        Assert.AreEqual(worker2, company.Workers.ElementAt(1));
    }

    [Test]
    public void WorkerListTest4()
    {
        TaskManagementSystem.Classes.Company company = new();
        company.Workers = new List<IWorker>();
        TaskManagementSystem.Classes.Worker worker1 = new();
        TaskManagementSystem.Classes.Worker worker2 = new();
        company.HireWorker(worker1);
        company.HireWorker(worker2);
        _ = company.FireWorkerAt(worker2.Id); // I assume ID is their number in the list.
        Assert.AreEqual(worker1.Id, company.Workers.ElementAt(0).Id);
    }

    [Test]
    public void HireWorker_WithMockWorker_ShouldBeAddedToList()
    {
        TaskManagementSystem.Classes.Company company = new();
        company.Workers = new List<IWorker>();

        var mock = new Mock<IWorker>();

        mock.Setup(w => w.Id).Returns(Guid.NewGuid());

        var mockWorker = mock.Object;

        company.HireWorker(mockWorker);

        Assert.AreEqual(1, company.Workers.Count);
        Assert.AreEqual(mockWorker, company.Workers.ElementAt(0));
    }
}