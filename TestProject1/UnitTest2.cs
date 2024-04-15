namespace TestProject1;

public class Test_methods
{
    [Test]
    public void Test2_1_1()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        author.goCity("Moscow");
        Assert.That(author.city, Is.EqualTo("Moscow"));
    }
    
    [Test]
    public void Test2_1_2()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = author.writeBook("Ejik and Yjik", "adventure", 5);
        Assert.That(book.bookName, Is.EqualTo("Ejik and Yjik"));
    }
    
    [Test]
    public void Test2_2_1()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = author.writeBook("Ejik and Yjik", "adventure", 5);
        Assert.That(book.bookName, Is.EqualTo("Ejik and Yjik"));
    }
}