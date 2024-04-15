namespace TestProject1;

public class Test_methods
{
    [Test]
    public void Test2_1_1()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        
        Assert.That(author.lastName, Is.EqualTo("Arkhipova"));
    }
}