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
        var book = new Book("Orange is new Black", "drama",  10000, author);
        book.setPages();
        Assert.IsTrue(book.pages> 9);
    }
    
    [Test]
    public void Test2_3_1()
    {
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        var critic = house.employCritic("Vasa", 5);
        Assert.That(critic.name, Is.EqualTo("Vasa"));
    }
    
    [Test]
    public void Test2_3_2()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        var contract = house.makeConract(1234 ,book);
        Assert.That(contract.number, Is.EqualTo(1234));
    }
    
    [Test]
    public void Test2_3_3()
    {
        var author = new Author("Anna", "Arkhipova",  "Moscow", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        var start = house.startPublic(book);
        Assert.IsTrue(start);
    }
    
    [Test]
    public void Test2_3_4()
    {
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 60);
        var start = house.startPublic(book);
        Assert.IsFalse(start);
    }
    
    [Test]
    public void Test2_3_5()
    {
        var author = new Author("Anna", "Arkhipova",  "Moscow", 20000);
        var book = new Book("Orange is new Black", "drama",  10000, author);
        
        var house = new PublishingHouse("A-Zbuka", "Moscow", 13, 12);
        var start = house.startPublic(book);
        Assert.IsFalse(start);
    }
    
    [Test]
    public void Test2_4_1()
    {
        var database = new DataBase();
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = author.writeBook("Ejik and Yjik", "adventure", 5);
        
        database.addCurrentBook(book);
        Assert.IsNotEmpty(database.books);
    }
    
    [Test]
    public void Test2_4_2()
    {
        var database = new DataBase();
        database.addBooks();
        Assert.IsNotEmpty(database.books);
    }
    
    [Test]
    public void Test2_4_3()
    {
        var database = new DataBase();
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = author.writeBook("Ejik and Yjik", "adventure", 5);
        
        database.addCurrentBook(book);
        var check = database.checkBook(book);
        Assert.IsFalse(check);
    }
    
    [Test]
    public void Test2_4_4()
    {
        var database = new DataBase();
        var author = new Author("Anna", "Arkhipova",  "Izhevsk", 20000);
        var book = author.writeBook("Ejik and Yjik", "adventure", 5);
        
        database.addCurrentBook(book);
        Assert.That(database.books[0].Value, Is.EqualTo("Ejik and Yjik"));
    }
}