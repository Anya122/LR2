namespace TestProject1;

public class Tests
{
    [Test]
    public void Test1()
    {
        var autor = new Autor("Anna");
        Assert.That(autor.Name, Is.EqualTo("Anna"));
        
    }
}