namespace TestProject1;

public class Tests
{
    [Test]
    public void Test1()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        Assert.That(author.firstName, Is.EqualTo("Anna"));
        
    }
    
    [Test]
    public void Test2()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk",  20000);
        Book myBook = author.writeBook("Priklychenia Yani and Yaka", "fantasy", 300000);
        Assert.That(myBook.GetAuthorCity(), Is.EqualTo("Izhevsk"));
        
    }
}