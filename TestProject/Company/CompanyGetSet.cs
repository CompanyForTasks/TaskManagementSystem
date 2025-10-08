using TaskManagementSystem.Classes;
using NUnit.Framework.Internal;
namespace TaskManagementSystem.Tests;
public class GetSetTest
{
    [Test]
    public void NameTest()
    {
        Company company = new();
        string testName = "Test1";
        company.Name = testName;
        Assert.AreEqual(company.Name, testName);
    }
    [Test]
    public void DescriptionTest()
    {
        Company company = new();
        string testDescription = "Test1";
        company.Description = testDescription;
        Assert.AreEqual(company.Description, testDescription);
    }
}
