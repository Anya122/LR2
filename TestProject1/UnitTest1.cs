namespace TestProject1;

public class Tests
{
    [Test]
    public void Test1()
    {
        var autor = new Autor("Anna", "Arkhipova", 21);
        Assert.That(autor.firstName, Is.EqualTo("Anna"));
        
    }
}