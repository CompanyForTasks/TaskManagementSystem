using TaskManagementSystem.Interfaces;

namespace TaskManagementSystem.Classes;

public class Company : ICompany
{
    // ����� ������
    public string Name { get; set; } = string.Empty;

    // ���� ������
    public string Description { get; set; } = string.Empty;
    public List<IWorker> Workers { get; set; }

    /*
     * The HireWorker(IWorker worker) method requires testing of the following scenarios
     * (using an IWorker mock object):
     *
     * 1. Successful addition:
     * - Input: A valid mock IWorker object (e.g., mockWorker)
     * that does NOT already exist in the Workers list.
     * - Expected: mockWorker is successfully added to the list.
     * Workers.Count should increase by 1.
     *
     * 2. Attempting to add null:
     * - Input: null.
     * - Expected: The method does not throw an exception (NRE).
     * The Workers list remains unchanged.
     *
     * 3. Attempting to add a duplicate (an existing worker):
     * - Input: A valid mock IWorker object (mockWorker)
     * that ALREADY EXISTS in the Workers list.
     * - Expected: The method does not throw an exception.
     * mockWorker is not added a second time.
     * The Workers list remains unchanged.
     */
    public void HireWorker(IWorker worker)
    {
        if (worker != null && !Workers.Contains(worker)) Workers.Add(worker);
    }

    public bool FireWorkerAt(Guid id)
    {
        var worker = Workers.FirstOrDefault(w => w.Id == id);
        if (worker != null)
        {
            _ = Workers.Remove(worker);
            return true;
        }

        return false;
    }
}