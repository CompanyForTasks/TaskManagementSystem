namespace TestProject.Company;
public class GetSetTest
{
    [Test]
    public void NameTest()
    {
        TaskManagementSystem.Classes.Company company = new();
        string testName = "Test1";
        company.Name = testName;
        Assert.AreEqual(company.Name, testName);
    }
    [Test]
    public void DescriptionTest()
    {
        TaskManagementSystem.Classes.Company company = new();
        string testDescription = "Test1";
        company.Description = testDescription;
        Assert.AreEqual(company.Description, testDescription);
    }
}
