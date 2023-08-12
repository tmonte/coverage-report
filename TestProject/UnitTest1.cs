using ConsoleApp;

namespace TestProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var myObj = new MyClass();
        var expected = 42;
        var actual = myObj.MyMethod("hello");
        Assert.That(actual, Is.EqualTo(expected));
    }
}